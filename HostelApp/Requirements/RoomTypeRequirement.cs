using HostelApp.Entities;
using HostelApp.Entities.Codes;

namespace HostelApp.Requirements
{
    public class RoomTypeRequirement : IRequirement
    {
        public List<RoomType> RoomTypes { get; set; } = new List<RoomType>();

        public Task<bool> CheckRoom(Room room) => 
            Task.FromResult(RoomTypes.Contains(room.RoomType) 
                || RoomTypes.Contains(RoomType.Все)
                || RoomTypes.All(t => !Enum.IsDefined(t)));        
    }
}
