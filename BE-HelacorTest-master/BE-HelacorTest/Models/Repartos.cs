using System.Diagnostics.CodeAnalysis;

namespace BE_HelacorTest.Models
{
    public class Repartos
    {
        public int Id { get; set; }
        public string Empresa_encargada { get; set; }
        public string Patente_vehiculo { get; set; }
        public int Cantidad_bultos { get; set; }
        public string Zona_destino { get; set; }
        public DateTime Fecha_salida { get; set; }
        public DateTime Fecha_estimada_entrega { get; set; }
        [AllowNull]
        public DateTime Fecha_entrega { get; set; }
        public string Estado_entrega { get; set; }
    }
}
