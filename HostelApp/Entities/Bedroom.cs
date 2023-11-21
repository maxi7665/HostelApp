using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Bedroom : Entity
    {
        [DisplayName("ИД комнаты")]
        public int RoomId { get; set; }

        [DisplayName("Площадь")]
        public double Area { get; set; }
    }
}
