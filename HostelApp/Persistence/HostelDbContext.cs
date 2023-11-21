using HostelApp.Entities;

namespace HostelApp.Persistence
{
    public class HostelDbContext : BaseDbContext
    {
        private static readonly HostelDbContext _instance = new HostelDbContext();

        static HostelDbContext()
        {
        }

        private HostelDbContext()
        {
        }

        public static HostelDbContext GetInstance()
        {            
            return _instance;            
        }

        /// <summary>
        /// Получить свободные комнаты на дату
        /// </summary>
        public async Task<List<Room>> GetVacantRooms(
            DateTime fromDate, 
            DateTime toDate)
        {
            var clearFromDate = fromDate.Date;
            var clearToDate = toDate.Date;

            var rooms = await GetRoomsAsync();

            var accomodations = (await GetAccomodationsAsync())
                .Where(acc =>
            {
                return acc.FromDate > toDate || acc.ToDate <= fromDate;
            });

            var result = rooms.Where(r =>
            {
                return !accomodations.Any(acc => acc.RoomId == r.Id);
            });

            return result.ToList();
        }

        /// <summary>
        /// Создать заселение
        /// </summary>
        public async Task CreateRoomAccomodation(
            int roomId, 
            DateTime fromDate, 
            DateTime toDate,
            int customerId)
        {
            var clearFromDate = fromDate.Date;
            var clearToDate = toDate.Date;

            var vacant = await GetVacantRooms(fromDate, toDate);

            if (!vacant.Any(r => r.Id == roomId))
            {
                throw new ApplicationException("Room is not vacant");
            }

            await AddAccomodationAsync(new Accomodation()
            {
                CustomerId = customerId,
                FromDate = clearFromDate,
                ToDate = clearToDate,
                RoomId = roomId
            });
        }

        /// <summary>
        /// Получить заселение в комнату на дату
        /// </summary>
        public async Task<Accomodation?> GetRoomAccomodationOnDate(
            int roomId,
            DateTime onDate)
        {
            var clearOnDate = onDate.Date;

            var accomodation = (await GetAccomodationsAsync()).Where(acc =>
            {
                return acc.RoomId == roomId
                    && acc.FromDate <= onDate
                    && acc.ToDate > onDate;
            }).FirstOrDefault();

            return accomodation;
        }
    }
}
