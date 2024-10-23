using MicroservicioPerros.Business.Services;
using MicroservicioPerros.Data.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioPerros.Presentacion.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDosService _dogService;

        public DogController(IDosService dogService)
        {
            _dogService = dogService;
        }

        [HttpPost]
        public IActionResult Inser(DogDTO dto) 
        {
            try
            {
                _dogService.Insert(dto);
                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_dogService.GetAll());
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            try
            {
                _dogService.Delete(id);

                return Ok($"Perro eliminado {id}");
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
