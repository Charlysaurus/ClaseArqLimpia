using System.Text.Json.Serialization;

namespace Libreria.Business.Entities
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public ICollection<Libro> Libro { get; set; }

        public Autor()
        {
            
        }

        public Autor(int id, string nombre, string nacionalidad)
        {
            this.AutorId = id;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }
    }
}
