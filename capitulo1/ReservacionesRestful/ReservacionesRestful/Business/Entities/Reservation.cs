namespace ReservacionesRestful.Business.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User {get; set;}
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime Begin {  get; set; }
        public DateTime Final { get; set; }


        public Reservation()
        {
            
        }
        public Reservation(int UserId, int RoomId, DateTime Begin, DateTime End) 
        {
            this.UserId = UserId;
            this.RoomId = RoomId;
            this.Begin = Begin;
            this.Final = End;
        }
    }
}
