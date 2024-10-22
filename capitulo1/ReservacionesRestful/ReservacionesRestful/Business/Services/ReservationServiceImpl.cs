using ReservacionesRestful.Business.Entities;
using ReservacionesRestful.Data.DTOs;
using ReservacionesRestful.Data.Repositories;

namespace ReservacionesRestful.Business.Services
{
    public class ReservationServiceImpl : IReservationService
    {
        private readonly UserRepository _userRepositroy;
        private readonly ReservationRepository _reservationRepositroy;
        private readonly RoomRepository _roomRepositroy;

        public ReservationServiceImpl(UserRepository userRepository, ReservationRepository reservationRepository, RoomRepository roomRepository)
        {
            _userRepositroy = userRepository;
            _reservationRepositroy = reservationRepository;
            _roomRepositroy = roomRepository;
        }

        public List<Reservation> GetAll()
        {
            return _reservationRepositroy.GetAll();
        }

        public List<Room> GetAvailableRooms()
        {
            return _roomRepositroy.GetAvailable();
        }

        public int Insert(ReservationDTO dto)
        {
            var user = new User();
            try
            {
                user = _userRepositroy.FindById(dto.UserId);
            }
            catch (Exception e)
            {
                Console.WriteLine($"No existe el usuario {e.Message}");
                throw e;
            }

            //busqueda de cuarto
            var room = new Room();
            try
            {
                room = _roomRepositroy.FindById(dto.RoomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            if (room.Available) 
            {
                Reservation reservation = new Reservation() 
                { 
                    UserId = dto.UserId, 
                    RoomId = dto.RoomId, 
                    Begin = dto.Begin, 
                    Final = dto.End 
                };

                int result = _reservationRepositroy.Insert(reservation);
                room.Available = false;
                _roomRepositroy.Update(room);
                return result;
            }

            throw new Exception($"Habitación no disponible {room.Id}");

        }
    }
}
