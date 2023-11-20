using HostelApp.Entities;

namespace HostelApp.Requirements
{
    public interface IRequirement
    {
        public Task<bool> CheckRoom(Room room);
    }
}
