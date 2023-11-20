using HostelApp.Entities;

namespace HostelApp.Requirements
{
    public class BathroomRequirement : IRequirement
    {
        public int MinBathroomNumber { get; set; } = 0;

        public int MaxBathroomNumber { get; set; } = 0;

        public Task<bool> CheckRoom(Room room)
        {
            return Task.FromResult(room.BathroomsCount >= MinBathroomNumber
                && (room.BathroomsCount <= MaxBathroomNumber
                || MaxBathroomNumber <= 0));
        }
    }
}
