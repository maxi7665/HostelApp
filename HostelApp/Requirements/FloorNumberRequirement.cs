using HostelApp.Entities;

namespace HostelApp.Requirements
{
    public class FloorNumberRequirement : IRequirement
    {
        public int MinFloorNumber { get; set; } = 0;

        public int MaxFloorNumber { get; set; } = 0;

        public Task<bool> CheckRoom(Room room)
        {
            var result = room.Floor >= MinFloorNumber
                && (room.Floor <= MaxFloorNumber
                || MaxFloorNumber <= 0);

            return Task.FromResult(result);
        }
    }
}
