using System.ComponentModel.DataAnnotations;

namespace Tp_Peliculas.Models
{
    public class Pelicula
    { 
        public int Id { get; set; }
        public string? Titulo { get; set; }
        [Display(Name = "Genero")]
        public int GeneroId { get; set; }

        public Genero? Generos { get; set; }
        public DateOnly FechaEstreno { get; set; }
        public string? Portada { get; set; }
        public string? Trailer { get; set; }
        public string? Resumen { get; set; }

    }
}
