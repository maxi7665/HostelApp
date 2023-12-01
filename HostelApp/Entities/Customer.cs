using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HostelApp.Entities
{
    public class Customer : Entity
    {
        [DisplayName("ФИО")]
        public string FullName { get; set; } = string.Empty;

        [DisplayName("Дата рождения")]
        [DisplayFormat(DataFormatString = "short")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Возраст")]
        public int Age { get => DateTime.UtcNow.Year - BirthDate.Year; }

        public override string? ToString()
        {
            return $"({Id}): {FullName}";
        }
    }
}
