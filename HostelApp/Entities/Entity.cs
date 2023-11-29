using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HostelApp.Entities
{
    public class Entity
    {
        [DisplayName("ИД")]
        [Key]
        public int Id { get; set; }
    }
}
