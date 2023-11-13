namespace HostelApp.Entities
{
    public class Accomodation : Entity
    { 
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int RoomId { get; set; }

        public int CustomerId { get; set; }
    }
}
