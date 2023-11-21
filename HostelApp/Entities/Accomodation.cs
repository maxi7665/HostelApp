using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Accomodation : Entity
    {
        [DisplayName("Дата С")]
        public DateTime FromDate { get; set; }

        [DisplayName("Дата ПО")]
        public DateTime ToDate { get; set; }

        [DisplayName("ИД номера")]
        public int RoomId { get; set; }

        [DisplayName("ИД постояльца")]
        public int CustomerId { get; set; }
    }
}
