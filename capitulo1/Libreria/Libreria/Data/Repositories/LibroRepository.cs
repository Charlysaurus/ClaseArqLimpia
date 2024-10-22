using Libreria.Business.Entities;

namespace Libreria.Data.Repositories
{
    public class LibroRepository
    {
        private readonly AppDBContext _dbContext;

        public LibroRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public List<Libro> GetAll()
        {
            return _dbContext.Libros.ToList();
        }

        public List<Libro> BuscarLibrosPorAutor(string nombreAutor)
        {
            
            var result = _dbContext.Libros.ToList().Where(x => x.Autor.Nombre == nombreAutor).ToList();
            if (result != null)
            {
                return result;
            }
            throw new Exception($"El autor {nombreAutor} no existe");
        }

        public int Insert(Libro libro)
        {
            _dbContext.Libros.Add(libro);

            var result = _dbContext.SaveChanges(); //commit

            return result;
        }
    }
}
