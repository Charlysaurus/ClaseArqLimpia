using MicroservicioPerros.Data.DTOs;

namespace MicroservicioPerros.Business.Services
{
    public interface IDosService
    {

        int Insert(DogDTO dto);
        List<DogDTO> GetAll();
        int Delete(int id);
    }
}
