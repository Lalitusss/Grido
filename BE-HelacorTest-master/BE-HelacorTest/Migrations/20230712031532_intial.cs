using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_HelacorTest.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repartos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa_encargada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patente_vehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad_bultos = table.Column<int>(type: "int", nullable: false),
                    Zona_destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_estimada_entrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_entrega = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado_entrega = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repartos", x => x.Id);
                });
                // Insertar datos precargados
                migrationBuilder.InsertData(
                table: "Repartos",
                columns: new[] {"Empresa_encargada", "Patente_vehiculo", "Cantidad_bultos", "Zona_destino", "Fecha_salida", "Fecha_estimada_entrega", "Fecha_entrega", "Estado_entrega" },
                values: new object[,] {{"Empresa 1","AA100CE",55,"CENTRO",new DateTime(2023,03,10),new DateTime(2023,03,13),new DateTime(2023,03,13),"ENTREGADO"},
                                        {"Empresa 2","AA101CE",56,"CENTRO",new DateTime(2023,03,11),new DateTime(2023,03,14),new DateTime(2023,03,14),"ENTREGADO"},
                                        {"Empresa 3","AA102CE",57,"CENTRO",new DateTime(2023,03,12),new DateTime(2023,03,15),new DateTime(2023,03,15),"ENTREGADO"},
                                        {"Empresa 4","AA103CE",58,"CENTRO",new DateTime(2023,03,13),new DateTime(2023,03,16),new DateTime(2023,03,16),"ENTREGADO"},
                                        {"Empresa 5","AA104CE",59,"CENTRO",new DateTime(2023,03,14),new DateTime(2023,03,17),new DateTime(2023,03,17),"ENTREGADO"},
                                        {"Empresa 6","AA105CR",60,"CENTRO",new DateTime(2023,03,15),new DateTime(2023,03,18),new DateTime(2023,03,18),"ENTREGADO"},
                                        {"Empresa 7","AA106CR",61,"CENTRO",new DateTime(2023,03,16),new DateTime(2023,03,19),new DateTime(2023,03,19),"ENTREGADO"},
                                        {"Empresa 8","AA107CR",62,"CENTRO",new DateTime(2023,03,17),new DateTime(2023,03,20),new DateTime(2023,03,20),"ENTREGADO"},
                                        {"Empresa 9","AA108CR",63,"CENTRO",new DateTime(2023,03,18),new DateTime(2023,03,21),new DateTime(2023,03,21),"ENTREGADO"},
                                        {"Empresa 10","AA109CR",64,"CENTRO",new DateTime(2023,03,19),new DateTime(2023,03,22),new DateTime(2023,03,22),"ENTREGADO"},
                                        {"Empresa 11","AA110DR",89,"CENTRO",new DateTime(2023,03,20),new DateTime(2023,03,23),new DateTime(2023,03,23),"ENTREGADO"},
                                        {"Empresa 12","AA111DR",90,"CENTRO",new DateTime(2023,03,21),new DateTime(2023,03,24),new DateTime(2023,03,24),"ENTREGADO"},
                                        {"Empresa 13","AA112DR",91,"CENTRO",new DateTime(2023,03,22),new DateTime(2023,03,25),new DateTime(2023,03,25),"ENTREGADO"},
                                        {"Empresa 14","AA113DR",92,"CENTRO",new DateTime(2023,03,23),new DateTime(2023,03,26),new DateTime(2023,03,27),"ENTREGADO_DEMORA"},
                                        {"Empresa 15","AA114DG",93,"CENTRO",new DateTime(2023,03,24),new DateTime(2023,03,27),new DateTime(2023,03,28),"ENTREGADO_DEMORA"},
                                        {"Empresa 16","AA115DG",94,"CENTRO",new DateTime(2023,03,25),new DateTime(2023,03,28),new DateTime(2023,03,29),"ENTREGADO_DEMORA"},
                                        {"Empresa 17","AA116DG",95,"LITORAL",new DateTime(2023,03,26),new DateTime(2023,03,31),new DateTime(2023,04,01),"ENTREGADO_DEMORA"},
                                        {"Empresa 18","AA117DG",101,"LITORAL",new DateTime(2023,03,27),new DateTime(2023,04,01),new DateTime(2023,04,02),"ENTREGADO_DEMORA"},
                                        {"Empresa 19","AA118DG",102,"LITORAL",new DateTime(2023,03,28),new DateTime(2023,04,02),new DateTime(2023,04,03),"ENTREGADO_DEMORA"},
                                        {"Empresa 20","AB119HG",103,"LITORAL",new DateTime(2023,03,29),new DateTime(2023,04,03),new DateTime(2023,04,04),"ENTREGADO_DEMORA"},
                                        {"Empresa 21","AB120HG",104,"LITORAL",new DateTime(2023,03,30),new DateTime(2023,04,04),new DateTime(2023,04,05),"ENTREGADO_DEMORA"},
                                        {"Empresa 22","AB121HG",105,"LITORAL",new DateTime(2023,03,31),new DateTime(2023,04,05),new DateTime(2023,04,06),"ENTREGADO_DEMORA"},
                                        {"Empresa 23","AB122HG",106,"LITORAL",new DateTime(2023,04,01),new DateTime(2023,04,06),new DateTime(9999,04,06),"NO_ENTREGADO"},
                                        {"Empresa 24","AB123HG",107,"LITORAL",new DateTime(2023,04,02),new DateTime(2023,04,07),new DateTime(9999,04,06),"NO_ENTREGADO"},
                                        {"Empresa 25","AB124HG",25,"LITORAL",new DateTime(2023,04,03),new DateTime(2023,04,08),new DateTime(9999,04,06),"NO_ENTREGADO"},
                                        {"Empresa 26","AB125HG",26,"LITORAL",new DateTime(2023,04,04),new DateTime(2023,04,09),new DateTime(2023,04,09),"ENTREGADO"},
                                        {"Empresa 27","AB126HG",27,"LITORAL",new DateTime(2023,04,05),new DateTime(2023,04,10),new DateTime(2023,04,10),"ENTREGADO"},
                                        {"Empresa 28","AB127HH",28,"LITORAL",new DateTime(2023,04,06),new DateTime(2023,04,11),new DateTime(2023,04,11),"ENTREGADO"},
                                        {"Empresa 29","AB128HH",29,"LITORAL",new DateTime(2023,04,07),new DateTime(2023,04,12),new DateTime(2023,04,12),"ENTREGADO"},
                                        {"Empresa 30","AB129HH",30,"LITORAL",new DateTime(2023,04,08),new DateTime(2023,04,13),new DateTime(2023,04,13),"ENTREGADO"},
                                        {"Empresa 31","AE130HU",31,"LITORAL",new DateTime(2023,04,09),new DateTime(2023,04,14),new DateTime(2023,04,14),"ENTREGADO"},
                                        {"Empresa 32","AE131RU",200,"LITORAL",new DateTime(2023,04,10),new DateTime(2023,04,15),new DateTime(2023,04,15),"ENTREGADO"},
                                        {"Empresa 33","AE132RU",201,"LITORAL",new DateTime(2023,04,11),new DateTime(2023,04,16),new DateTime(2023,04,16),"ENTREGADO"},
                                        {"Empresa 34","AE133RU",202,"PATAGONIA",new DateTime(2023,04,12),new DateTime(2023,04,19),new DateTime(2023,04,19),"ENTREGADO"},
                                        {"Empresa 35","AE134RU",203,"PATAGONIA",new DateTime(2023,04,13),new DateTime(2023,04,20),new DateTime(2023,04,20),"ENTREGADO"},
                                        {"Empresa 36","AE135RU",204,"PATAGONIA",new DateTime(2023,04,14),new DateTime(2023,04,21),new DateTime(2023,04,21),"ENTREGADO"},
                                        {"Empresa 37","AE136RU",10,"PATAGONIA",new DateTime(2023,04,15),new DateTime(2023,04,22),new DateTime(2023,04,24),"ENTREGADO_DEMORA"},
                                        {"Empresa 38","AE137RA",11,"PATAGONIA",new DateTime(2023,04,16),new DateTime(2023,04,23),new DateTime(2023,04,25),"ENTREGADO_DEMORA"},
                                        {"Empresa 39","AE138RA",12,"PATAGONIA",new DateTime(2023,04,17),new DateTime(2023,04,24),new DateTime(2023,04,26),"ENTREGADO_DEMORA"},
                                        {"Empresa 40","AE139RA",13,"PATAGONIA",new DateTime(2023,04,18),new DateTime(2023,04,25),new DateTime(2023,04,27),"ENTREGADO_DEMORA"}

                                        });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repartos");
        }
    }
}
