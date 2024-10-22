using Libreria.Business.Services;
using Libreria.Data.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaController : ControllerBase
    {

        private readonly IBuscaLibroService _buscalibroService;

        public LibreriaController(IBuscaLibroService buscaLibroService)
        {
            _buscalibroService = buscaLibroService;
        }

        [HttpPost]
        public IActionResult Create(GuardaLibroDTO dto)
        {
            try
            {
                var result = _buscalibroService.InsertarLibro(dto);

                return result > 0 ? Created() : BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("libros")]
        public IActionResult GetAll()
        {
            return Ok(_buscalibroService.ObtenerTodosLosLibros());
        }

        [HttpGet("librosautor")]
        public IActionResult GetAvailableRooms(string nombreAutor)
        {
            return Ok(_buscalibroService.BuscarLibrosPorAutor(nombreAutor));
        }
    }
}
