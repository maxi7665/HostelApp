using HostelApp.Entities;

namespace HostelApp.Requirements
{
    public class RequirementSet : IRequirement
    {
        public List<IRequirement> Requirements { get; set; }

        public RequirementSet(List<IRequirement> requirements)
        {
            Requirements = requirements;
        }

        public async Task<bool> CheckRoom(Room room)
        {
            foreach (var requirement in Requirements)
            {
                if (!(await requirement.CheckRoom(room)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
