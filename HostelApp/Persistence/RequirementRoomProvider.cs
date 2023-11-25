using HostelApp.Entities;
using HostelApp.Requirements;

namespace HostelApp.Persistence
{
    public class RequirementRoomProvider
    {
        private readonly RequirementSet _requirementSet;

        public RequirementRoomProvider(RequirementSet requirementSet)
        {
            _requirementSet = requirementSet;
        }

        public async Task<List<Room>> GetRoomsAsync()
        {
            var context = HostelDbContext.GetInstance();

            var rooms = (await context.GetRoomsAsync())
                .Where(r => _requirementSet.CheckRoom(r)
                .GetAwaiter()
                .GetResult())
                .ToList();

            return rooms;
        }

        public async Task<List<Room>> GetVacantRoomsAsync(
            DateTime fromDate, 
            DateTime toDate)
        {
            var context = HostelDbContext.GetInstance();

            var rooms = (await context.GetVacantRooms(
                fromDate,
                toDate))
                .Where(r => _requirementSet.CheckRoom(r)
                .GetAwaiter()
                .GetResult())
                .ToList();

            return rooms;
        }
    }
}
