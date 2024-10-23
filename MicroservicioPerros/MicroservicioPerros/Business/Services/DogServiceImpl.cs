using MicroservicioPerros.Business.Entities;
using MicroservicioPerros.Data.DTOs;
using MicroservicioPerros.Data.Repositories;
using Org.BouncyCastle.Security;

namespace MicroservicioPerros.Business.Services
{
    public class DogServiceImpl : IDosService
    {
        private readonly DogRepository _dosRepository;
        public DogServiceImpl(DogRepository dogRepository)
        {
                _dosRepository = dogRepository;
        }
        public int Delete(int id)
        {
            return _dosRepository.Delete(id);
        }

        public List<DogDTO> GetAll()
        {
            return _dosRepository.GetAll().Select(t => 
            new DogDTO() 
            {
                Id = t.Id, 
                Name = t.Name, 
                Description = t.Description, 
                URLImage = t.URLImage 
            }).ToList();
        }

        public int Insert(DogDTO dto)
        {
            return _dosRepository.Insert(
                new Dog() 
                {
                    Id = dto.Id,
                    Name = dto.Name,
                    Description = dto.Description,
                    URLImage = dto.URLImage
                });
        }
    }
}
