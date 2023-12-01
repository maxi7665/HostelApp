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
                    return acc.FromDate < toDate && acc.ToDate > fromDate;
                })
                .Select(acc => acc.RoomId)
                .ToHashSet();

            var result = rooms.Where(r =>
            {
                return !accomodations.Contains(r.Id);
            });

            return result.ToList();
        }

        /// <summary>
        /// Создать заселение
        /// </summary>
        public async Task<Accomodation> CreateRoomAccomodationAsync(
            int roomId, 
            DateTime fromDate, 
            DateTime toDate,
            int customerId)
        {
            var clearFromDate = fromDate.Date;
            var clearToDate = toDate.Date;

            if (clearFromDate >= clearToDate)
            {
                throw new ApplicationException("Даты указаны неверно");
            }

            var vacant = await GetVacantRooms(clearFromDate, clearToDate);

            if (!vacant.Any(r => r.Id == roomId))
            {
                throw new ApplicationException($"Комната занята на даты {clearFromDate}-{clearToDate}");
            }

            var customerConflictAccomodationExists = GetAccomodationsAsync()
                .GetAwaiter()
                .GetResult()
                .Where(acc => acc.CustomerId == customerId
                    && clearFromDate < acc.ToDate
                    && clearToDate > acc.FromDate)
                .Any();

            if (customerConflictAccomodationExists)
            {
                throw new ApplicationException(
                    $"Гость " +
                    $"{GetCustomerAsync(customerId).GetAwaiter().GetResult()} " +
                    $"уже имеет заселения на даты {clearFromDate}-{clearToDate}");
            }

            var acc = new Accomodation()
            {
                CustomerId = customerId,
                FromDate = clearFromDate,
                ToDate = clearToDate,
                RoomId = roomId
            };

            await AddAccomodationAsync(acc);

            return acc;
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
