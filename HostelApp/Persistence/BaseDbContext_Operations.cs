using HostelApp.Entities;

namespace HostelApp.Persistence
{
    public partial class BaseDbContext
    {
        public async Task<List<Room>> GetRoomsAsync() => await GetEntities<Room>();

        public async Task<Room?> GetRoomAsync(int id) => await GetEntity<Room>(id);

        public async Task AddRoomAsync(Room room) => await AddEntity(room);

        public async Task UpdateRoomAsync(Room room) => await UpdateEntity(room);

        public async Task DeleteRoomAsync(int id) => await DeleteEntity<Room>(id);


        public async Task<List<Accomodation>> GetAccomodationsAsync() => await GetEntities<Accomodation>();

        public async Task<Accomodation?> GetAccomodationAsync(int id) => await GetEntity<Accomodation>(id);

        public async Task AddAccomodationAsync(Accomodation accomodation) => await AddEntity(accomodation);

        public async Task UpdateAccomodationAsync(Accomodation accomodation) => await UpdateEntity(accomodation);

        public async Task DeleteAccomodationAsync(int id) => await DeleteEntity<Accomodation>(id);


        public async Task<List<Bedroom>> GetBedroomsAsync() => await GetEntities<Bedroom>();

        public async Task<Bedroom?> GetBedroomAsync(int id) => await GetEntity<Bedroom>(id);

        public async Task AddBedroomAsync(Bedroom bedroom) => await AddEntity(bedroom);

        public async Task UpdateBedroomAsync(Bedroom bedroom) => await UpdateEntity(bedroom);

        public async Task DeleteBedroomAsync(int id) => await DeleteEntity<Bedroom>(id);

        public async Task<List<Bedroom>> GetRoomBedroomsAsync(int roomId) => 
            (await GetBedroomsAsync()).Where(b => b.RoomId == roomId).ToList();


        public async Task<List<Bed>> GetBedsAsync() => await GetEntities<Bed>();

        public async Task<Bed?> GetBedAsync(int id) => await GetEntity<Bed>(id);

        public async Task AddBedAsync(Bed bed) => await AddEntity(bed);

        public async Task UpdateBedAsync(Bed bed) => await UpdateEntity(bed);

        public async Task DeleteBedAsync(int id) => await DeleteEntity<Bed>(id);

        public async Task<List<Bed>> GetBedroomBedsAsync(int bedroomId) =>
            (await GetBedsAsync()).Where(b => b.BedroomId == bedroomId).ToList();


        public async Task<List<Customer>> GetCustomerAsync() => await GetEntities<Customer>();

        public async Task<Customer?> GetCustomerAsync(int id) => await GetEntity<Customer>(id);

        public async Task AdCustomerAsync(Customer customer) => await AddEntity(customer);

        public async Task UpdateCustomerAsync(Bed customer) => await UpdateEntity(customer);

        public async Task DeleteCustomerAsync(int id) => await DeleteEntity<Customer>(id);
    }
}
