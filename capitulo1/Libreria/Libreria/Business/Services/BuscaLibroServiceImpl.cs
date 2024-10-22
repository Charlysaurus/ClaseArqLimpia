using Libreria.Business.Entities;
using Libreria.Data.DTOs;
using Libreria.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Business.Services
{
    public class BuscaLibroServiceImpl : IBuscaLibroService
    {
        private readonly AutorRepository _autorRepositroy;
        private readonly LibroRepository _libroRepositroy;
        

        public BuscaLibroServiceImpl(AutorRepository autorRepository, LibroRepository libroRepository)
        {
            _autorRepositroy = autorRepository;
            _libroRepositroy = libroRepository;
            
        }


        public List<Libro> BuscarLibrosPorAutor(string nombreAutor)
        {
            return _libroRepositroy.BuscarLibrosPorAutor(nombreAutor);
        }

        public int InsertarLibro(GuardaLibroDTO nvoLibro)
        {
            
            Libro nuevoLibro = new Libro() 
            {
                Nombre = nvoLibro.Nombre,
                AutorId = nvoLibro.AutorId,
                LibroId = nvoLibro.LibroId,
                Descripcion = nvoLibro.Descripcion
            };

            int resultado = _libroRepositroy.Insert(nuevoLibro);

            return resultado;

        }

        public List<Libro> ObtenerTodosLosLibros()
        {
            return _libroRepositroy.GetAll();
        }
    }
}
