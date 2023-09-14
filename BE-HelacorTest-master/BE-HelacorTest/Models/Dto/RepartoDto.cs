using System.Diagnostics.CodeAnalysis;

namespace BE_HelacorTest.Models.dto
{
    public class RepartoDto
    {
        public int Id { get; set; }
        public string? Empresa_encargada { get; set; }
        public string? Patente_vehiculo { get; set; }
        public int Cantidad_bultos { get; set; }
        public DateTime Fecha_salida { get; set; }
        public string? Estado_entrega { get; set; }
    }
}
