using DocumentFormat.OpenXml.Wordprocessing;

namespace Tp_Peliculas.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateOnly  FechaNacimiento { get; set; }
        public string? Foto { get; set; }
    }
}
