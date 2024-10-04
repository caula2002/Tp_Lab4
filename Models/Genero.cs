namespace Tp_Peliculas.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public List<Pelicula>? Peliculas { get; set; }
    }
}
