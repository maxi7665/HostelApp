using HostelApp.Entities;

namespace HostelApp.Persistence
{
    public class RootScheme
    {
        public List<Room> Rooms = new();

        public List<Customer> Customers = new();

        public List<Bedroom>  Bedrooms = new();

        public List<Bed> Beds = new();

        public List<Accomodation> Accomodations = new();
    }
}
