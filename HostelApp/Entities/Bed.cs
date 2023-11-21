using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Bed : Entity
    {
        [DisplayName("ИД спальни")]

        public int BedroomId { get; set; }

        [DisplayName("Вместимость")]
        public int Capacity { get; set; }
    }
}
