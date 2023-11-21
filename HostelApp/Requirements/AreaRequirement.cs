using HostelApp.Entities;
using HostelApp.Persistence;

namespace HostelApp.Requirements
{
    public class AreaRequirement : IRequirement
    {
        public double MinArea { get; set; } = 0;

        public double MaxArea { get; set; } = 0;

        public async Task<bool> CheckRoom(Room room)
        {
            var context = HostelDbContext.GetInstance();
            
            var area = (await context.GetRoomBedroomsAsync(room.Id)).Sum(x => x.Area);

            return area >= MinArea
                && area <= MaxArea
                || MaxArea <= 0;
        }
    }
}
