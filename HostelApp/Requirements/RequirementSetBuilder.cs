using HostelApp.Entities.Codes;

namespace HostelApp.Requirements
{
    public class RequirementSetBuilder
    {
        private readonly List<IRequirement> _requirements = new();

        public RequirementSetBuilder AddCapacityRequrement(
            int minCapacity, 
            int maxCapacity = 0)
        {
            var requirement = new CapacityRequirement()
            {
                MinCapacity = minCapacity,
                MaxCapacity = maxCapacity
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddRoomTypeRequirement(
            IEnumerable<RoomType> roomTypes)
        {
            var requirement = new RoomTypeRequirement()
            {
                RoomTypes = roomTypes.ToList()
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddBedRequirement(
            int bedCapacity,
            int bedNumber)
        {
            var requirement = new BedRequirement()
            {
                BedCapacity = bedCapacity,
                BedCount = bedNumber
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddFloorNumberRequirement(
            int minFloor,
            int maxFloor)
        {
            var requirement = new FloorNumberRequirement()
            {
                MinFloorNumber = minFloor,
                MaxFloorNumber = maxFloor
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddAreaRequirement(
            double minArea, 
            double maxArea)
        {
            var requirement = new AreaRequirement()
            {
                MinArea = minArea,
                MaxArea = maxArea
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddBedroomRequirement(
            int minBedrooms,
            int maxBedrooms)
        {
            var requirement = new BedroomRequirement()
            {
                MinBedroomNumber = minBedrooms,
                MaxBedroomNumber = maxBedrooms
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSetBuilder AddBathroomRequirement(
            int minBathrooms,
            int maxBathrooms)
        {
            var requirement = new BathroomRequirement()
            {
                MinBathroomNumber = minBathrooms,
                MaxBathroomNumber = maxBathrooms
            };

            _requirements.Add(requirement);

            return this;
        }

        public RequirementSet BuildRequirementSet()
        {
            return new RequirementSet(_requirements);
        }
    }
}
