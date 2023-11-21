using HostelApp.Entities;
using HostelApp.Persistence;

namespace HostelApp.Requirements
{
    public class BedRequirement : IRequirement
    {
        public int BedCount { get; set; }

        public int BedCapacity { get; set; }

        public async Task<bool> CheckRoom(Room room)
        {
            var context = HostelDbContext.GetInstance();

            var beds = (await context.GetRoomBedroomsAsync(room.Id))
                .Aggregate(
                    new List<Bed>(),
                    (list, bedroom) =>
                    {
                        list.AddRange(context
                            .GetBedroomBedsAsync(bedroom.Id)
                            .GetAwaiter()
                            .GetResult());

                        return list;
                    })
                .Where(b => b.Capacity == BedCapacity);

            return beds.Count() >= BedCount;
        }
    }
}
