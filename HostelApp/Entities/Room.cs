using HostelApp.Entities.Codes;
using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Room : Entity
    {
        [DisplayName("Код номера")]
        public int Number { get; set; }

        [DisplayName("Наименование")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Тип")]
        public RoomType RoomType { get; set; }

        [DisplayName("Кол-во ванных")]
        public int BathroomsCount { get; set; }

        [DisplayName("Этаж")]
        public int Floor { get; set; }

        [DisplayName("Площадь")]
        public double Area { get; set; }
    }
}
