using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Customer : Entity
    {
        [DisplayName("ФИО")]
        public string FullName { get; set; } = string.Empty;

        [DisplayName("Дата рождения")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Возраст")]
        public int Age { get => DateTime.UtcNow.Year - BirthDate.Year; }
    }
}
