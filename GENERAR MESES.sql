USE [BD_Integracion]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[sp_Cheques_Anticipo_Completar_Minimo_Meses] (@temporada as NVARCHAR(7)) AS

DECLARE @countTemporada as INT
DECLARE @montoMaximoCheque as int

SET @countTemporada=(SELECT COUNT(*) FROM [dbo].[Cheques_Anticipo_Base_Calculo] WHERE temporada=@temporada)

PRINT @countTemporada

DECLARE @desde date, @hasta date
SELECT @desde = desde, @hasta = hasta from [dbo].[Cheques_Anticipo_Rango_Fecha_Comprobantes] where temporada = @temporada;


DECLARE @MIN_HELACOR NUMERIC(18,0),@MIN_MH NUMERIC(18,0);
SELECT @MIN_HELACOR = monto_min_helacor,@MIN_MH = monto_min_mh FROM [dbo].[Cheques_Anticipo_Valores] where temporada = @TEMPORADA;

CREATE TABLE #Meses (mes int,anio int);
INSERT INTO #Meses
SELECT  Month(DATEADD(MONTH, x.number, @DESDE)) AS mes,YEAR(DATEADD(MONTH, x.number, @DESDE)) + 1 AS anio
		FROM    master.dbo.spt_values x
		WHERE   x.type = 'P'
		AND     x.number <= DATEDIFF(MONTH, @DESDE, @hasta)

IF @countTemporada>0
BEGIN

	DECLARE @anio int
	DECLARE @mes int 
	DECLARE @sociedad nvarchar(4)
	DECLARE @cliente nvarchar(10)
	DECLARE @anticipo float


	DECLARE cursor_Clientes CURSOR STATIC FOR
	SELECT DISTINCT cliente FROM [BD_Integracion_Testing].[dbo].[Cheques_Anticipo_Base_Calculo] where temporada = @temporada 

	OPEN cursor_Clientes
	FETCH NEXT FROM cursor_Clientes INTO @cliente

	WHILE @@FETCH_STATUS = 0
	BEGIN
		DECLARE cursor_MesesPeriodo CURSOR STATIC FOR	
		SELECT mes,anio FROM #Meses
	   
	   OPEN cursor_MesesPeriodo
	   FETCH NEXT FROM cursor_MesesPeriodo INTO @mes,@anio
   
	   WHILE @@FETCH_STATUS = 0
	   BEGIN

		IF NOT EXISTS (SELECT distinct anio,mes,sociedad,cliente FROM [dbo].[Cheques_Anticipo_Base_Calculo] WHERE anio = @anio and mes = @mes  AND temporada = @temporada and sociedad = 1000 and cliente = @cliente)
			INSERT INTO [dbo].[Cheques_Anticipo_Base_Calculo] (anio, mes, sociedad, cliente, anticipo,temporada) VALUES (@anio,@mes,1000,@cliente,@MIN_HELACOR,@temporada)
		
		IF NOT EXISTS (SELECT distinct anio,mes,sociedad,cliente FROM [dbo].[Cheques_Anticipo_Base_Calculo] WHERE anio = @anio and mes = @mes  AND temporada = @temporada and sociedad = 2000 and cliente = @cliente)
			INSERT INTO [dbo].[Cheques_Anticipo_Base_Calculo] (anio, mes, sociedad, cliente, anticipo,temporada) VALUES (@anio,@mes,2000,@cliente,@MIN_MH,@temporada)

		  FETCH NEXT FROM cursor_MesesPeriodo INTO @mes,@anio
	   END
   
	   CLOSE cursor_MesesPeriodo
	   DEALLOCATE cursor_MesesPeriodo
  
   
	   FETCH NEXT FROM cursor_Clientes INTO @cliente
	END

	CLOSE cursor_Clientes
	DEALLOCATE cursor_Clientes

	DROP TABLE #Meses
END

