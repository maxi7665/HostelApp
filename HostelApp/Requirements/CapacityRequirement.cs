using HostelApp.Entities;
using HostelApp.Persistence;

namespace HostelApp.Requirements
{
    public class CapacityRequirement : IRequirement
    {
        public int MinCapacity { get; set; }

        public int MaxCapacity { get; set; }

        public async Task<bool> CheckRoom(Room room)
        {
            var context = HostelDbContext.GetInstance();

            var capacity = 0;

            foreach (var bedroom in await context.GetRoomBedroomsAsync(room.Id))
            {
                foreach (var bed in await context.GetBedroomBedsAsync(bedroom.Id))
                {
                    capacity += bed.Capacity;
                }
            }

            return capacity >= MinCapacity 
                && (capacity <= MaxCapacity 
                || MaxCapacity == 0); 
        }
    }
}
