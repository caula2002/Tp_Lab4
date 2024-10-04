namespace Tp_Peliculas.Models
{
    public class PeliculaActores
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }

        public Pelicula? Peliculas { get; set; }
        public int PersonaId { get; set; }

        public Actor? Actores { get; set; }

    }
}
