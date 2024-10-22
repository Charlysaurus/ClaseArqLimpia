using Libreria.Business.Entities;
using Libreria.Data.DTOs;

namespace Libreria.Business.Services
{
    public interface IBuscaLibroService
    {
        int InsertarLibro(GuardaLibroDTO nvoLibro);
        List<Libro> BuscarLibrosPorAutor(string nombreAutor);
        List<Libro> ObtenerTodosLosLibros();
    }
}
