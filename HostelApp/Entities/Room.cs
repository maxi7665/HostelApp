using HostelApp.Entities.Codes;

namespace HostelApp.Entities
{
    public class Room : Entity
    {
        public int Number { get; set; }

        public string Name { get; set; } = string.Empty;

        public RoomType RoomType { get; set; }

        public int BathroomsCount { get; set; }

        public int Floor { get; set; }

        public double Area { get; set; }
    }
}
