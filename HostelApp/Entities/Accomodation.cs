using HostelApp.Persistence;
using System.ComponentModel;

namespace HostelApp.Entities
{
    public class Accomodation : Entity
    {       
        [DisplayName("ИД номера")]
        public int RoomId { get; set; }

        [DisplayName("Наименование номера")]
        public string RoomName => HostelDbContext
           .GetInstance()
           .GetRoomAsync(RoomId)
           .GetAwaiter()
           .GetResult()?.Name
           ?? string.Empty;

        [DisplayName("ИД гостя")]
        public int CustomerId { get; set; }

        [DisplayName("Имя гостя")]
        public string CustomerName => HostelDbContext
            .GetInstance()
            .GetCustomerAsync(CustomerId)
            .GetAwaiter()
            .GetResult()?.FullName 
            ?? string.Empty;

        [DisplayName("Дата С")]
        public DateTime FromDate { get; set; }

        [DisplayName("Дата ПО")]
        public DateTime ToDate { get; set; }
    }
}
