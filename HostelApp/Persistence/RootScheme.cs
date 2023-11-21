using HostelApp.Entities;

namespace HostelApp.Persistence
{
    public class RootScheme
    {
        public List<Room> Rooms { get; set; } = new();

        public List<Customer> Customers { get; set; } = new();

        public List<Bedroom> Bedrooms { get; set; } = new();

        public List<Bed> Beds { get; set; } = new();

        public List<Accomodation> Accomodations { get; set; } = new();
    }
}
