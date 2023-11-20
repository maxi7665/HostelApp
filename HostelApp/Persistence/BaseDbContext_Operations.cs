using HostelApp.Entities;

namespace HostelApp.Persistence
{
    public partial class BaseDbContext
    {
        public async Task<List<Room>> GetRooms() => await GetEntities<Room>();

        public async Task<Room?> GetRoom(int id) => await GetEntity<Room>(id);

        public async Task AddRoom(Room room) => await AddEntity(room);

        public async Task UpdateRoom(Room room) => await UpdateEntity(room);

        public async Task DeleteRoom(int id) => await DeleteEntity<Room>(id);


        public async Task<List<Accomodation>> GetAccomodations() => await GetEntities<Accomodation>();

        public async Task<Accomodation?> GetAccomodation(int id) => await GetEntity<Accomodation>(id);

        public async Task AddAccomodation(Accomodation accomodation) => await AddEntity(accomodation);

        public async Task UpdateAccomodation(Accomodation accomodation) => await UpdateEntity(accomodation);

        public async Task DeleteAccomodation(int id) => await DeleteEntity<Accomodation>(id);


        public async Task<List<Bedroom>> GetBedrooms() => await GetEntities<Bedroom>();

        public async Task<Bedroom?> GetBedroom(int id) => await GetEntity<Bedroom>(id);

        public async Task AddBedroom(Bedroom bedroom) => await AddEntity(bedroom);

        public async Task UpdateBedroom(Bedroom bedroom) => await UpdateEntity(bedroom);

        public async Task DeleteBedroom(int id) => await DeleteEntity<Bedroom>(id);

        public async Task<List<Bedroom>> GetRoomBedrooms(int roomId) => 
            (await GetBedrooms()).Where(b => b.RoomId == roomId).ToList();


        public async Task<List<Bed>> GetBeds() => await GetEntities<Bed>();

        public async Task<Bed?> GetBed(int id) => await GetEntity<Bed>(id);

        public async Task AddBed(Bed bed) => await AddEntity(bed);

        public async Task UpdateBed(Bed bed) => await UpdateEntity(bed);

        public async Task DeleteBed(int id) => await DeleteEntity<Bed>(id);

        public async Task<List<Bed>> GetBedroomBeds(int bedroomId) =>
            (await GetBeds()).Where(b => b.BedroomId == bedroomId).ToList();


        public async Task<List<Customer>> GetCustomer() => await GetEntities<Customer>();

        public async Task<Customer?> GetCustomer(int id) => await GetEntity<Customer>(id);

        public async Task AddBed(Customer customer) => await AddEntity(customer);

        public async Task UpdateCustomer(Bed customer) => await UpdateEntity(customer);

        public async Task DeleteCustomer(int id) => await DeleteEntity<Customer>(id);
    }
}
