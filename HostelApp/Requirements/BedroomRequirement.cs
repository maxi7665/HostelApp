using HostelApp.Entities;
using HostelApp.Persistence;

namespace HostelApp.Requirements
{
    public class BedroomRequirement : IRequirement
    {
        public int MinBedroomNumber { get; set; } = 0;

        public int MaxBedroomNumber { get; set; } = 0;

        public async Task<bool> CheckRoom(Room room)
        {
            var context = HostelDbContext.GetInstance();

            var bedroomCount = (await context.GetRoomBedroomsAsync(room.Id)).Count;

            return bedroomCount >= MinBedroomNumber
                && (bedroomCount <= MaxBedroomNumber
                || MaxBedroomNumber <= 0);
        }
    }
}
