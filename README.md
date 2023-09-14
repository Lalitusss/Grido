# Grido

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<style>
* {
  box-sizing: border-box;
}

.menu {
  float: left;
  width: 20%;
  text-align: center;
}

.menu a {
  background-color: #e5e5e5;
  padding: 8px;
  margin-top: 7px;
  display: block;
  width: 100%;
  color: black;
}

.main {
  float: left;
  width: 60%;
  padding: 0 20px;
}



@media only screen and (max-width: 620px) {
  /* For mobile phones: */
  .menu, .main, .right {
    width: 100%;
  }
}
</style>
</head>
<body style="font-family:Verdana;color:#313131;">

<div style="background-color:#10069f;color:white;padding:15px;text-align:center;">
  <h1>Helacor Test</h1>
</div>

<div style="overflow:auto">
  <div class="menu">
<img src="https://api.gestionfranquicias.com.ar/Content/Images/grido_nuevo.png" style="max-width:100%;height:auto;">
  </div>

  <div class="main">
    <h2>Proyecto</h2>
    <p>La siguiente prueba técnica se constituye de un código Back End desarrollado en <b>.NetCore</b> que funciona como API y un código Front End desarrollado en <b>Angular Material</b> el cual consumirá los métodos del primero.</p>
      <p>Lo que se busca es que el candidato pueda identificar lo necesario para realizar una integración de las mismas, para la lectura de datos que serán precargados.</p>
      
      <h3>Pre-Requisitos</h3>
      <p>Se debe tener preparado un entorno con los siguientes programas:</p>
      <ul>
        <li>Visual Studio Community 2022</li>
        <li>SQL Server versión 2018 o superior</li>
        <li>Node JS versión 16 o superior</li>
        <li>Visual Studio Code 1.80.0 o superior, o editor de preferencia</li>
      </ul>
      <h3>Especificaciones</h3>
      
      <h4>BackEnd</h4>
      <p>Aquí se especifican los detalles técnicos del proyecto:</p>

      <ul>
          <li>Se desarrolló utilizando <b>NetFramework 6.0</b>, por lo que las pruebas de los métodos de API podrán ser probados con Swagger.</li>
          <li>Tiene incorporadas las siguientes dependencias:</li>
          <ol>
            <li>Entity Framework Core 7.0.8</li>
            <li>Entity Framework Core Tools 7.0.8</li>
              <li>Entity Framework Core SQL Server 7.0.8</li>
            <li>AutoMapper.Extensions.Microsoft.DependencyInjection 12.0</li>
          </ol>
          <li><b>No es necesario agregar ninguna otra dependencia</b></li>
      </ul>
      
      <p>Al abrir el proyecto y antes de recompilar, el candidato deberá en primera instancia ingresar su instancia de base de datos local dentro del archivo <b>appsettings.json</b>, esto con el objetivo de realizar la conexión con el motor de base de datos.</p>
      <p>Se provee con una migración inicial generada con <b>Entity Framework</b>, la cual contiene la estructura de la tabla a utilizar y datos pre cargados, solo bastará con ejecutar el comando <b>Update-database</b> en la Consola del Administrador de paquetes </p>
      <p>Se deben definir los métodos de <b>Get()</b>, utilizando el patrón repositorio. Los mismos deben ser asincrónicos.</p>
      <p>Utilizar el Data Transfer Object (DTO) <b>RepartoDto</b>, para obtener solo los siguientes datos:</p>
      <ul>
          <li>Id</li>
          <li>Empresa_encargada</li>
          <li>Patente_vehiculo</li>
          <li>Cantidad_bultos</li>
          <li>Fecha_salida</li>
          <li>Estado_entrega</li>
      </ul>
      
      
  </div>

</div>

<div style="background-color:#10069f;color:white;text-align:center;padding:10px;margin-top:7px;">&copy; <script>new Date().getFullYear()>document.write(new Date().getFullYear());</script></div>

</body>
</html>
