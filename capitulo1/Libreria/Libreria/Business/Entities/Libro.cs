using System.Text.Json.Serialization;

namespace Libreria.Business.Entities
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public int AutorId  { get; set; }

        [JsonIgnore]
        public Autor Autor { get; set; }

        public Libro()
        {

        }
        public Libro(int id, string nombre, string descripcion, int autorid)
        {
            this.LibroId = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.AutorId = autorid;
        }
    }
}
