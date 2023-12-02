using HostelApp.Entities;
using HostelApp.Persistence;
using System.Diagnostics;

namespace HostelApp.Extensions
{
    public static class HostelDbContextExtensions
    {
        public static async Task GenerateTestDataSetAsync(this HostelDbContext context)
        {
            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                var fileName = Path.GetRandomFileName();

                context.SetDatabaseFullFileName(fileName);
            }

            using var writeSession = context.BeginSession();

            var rooms = await context.GetRoomsAsync();

            rooms.Clear();

            for (int i = 0; i < 100; i++)
            {
                var customer = GenerateRandomCustomer();

                await context.AddCustomerAsync(customer);
            }

            for (int i = 0; i <= 100; i++)
            {
                var room = GenerateRandomRoom();                

                await context.AddRoomAsync(room);

                if (i % 2 == 0)
                {
                    var acc = GenerateRandomAccomodation(room.Id);

                    await context.CreateRoomAccomodationAsync(
                        acc.RoomId, 
                        acc.FromDate, 
                        acc.ToDate, 
                        acc.CustomerId);
                }

                var bedrooms = GenerateRandomBedroomList(room.Area);

                bedrooms.ForEach(async b => 
                {
                    b.RoomId = room.Id;

                    await context.AddBedroomAsync(b);

                    var beds = GenerateRandomBedList();

                    beds.ForEach(async bed =>
                    {
                        bed.BedroomId = b.Id;

                        await context.AddBedAsync(bed);
                    });
                });
            }                  
        }

        private static Room GenerateRandomRoom()
        {
            var random = new Random();

            var room = new Room()
            {
                // 20.xx - 100.xx
                Area = (double)(int)(((random.NextDouble() * 80) + 20) * 100) / 100,
                RoomType = (Entities.Codes.RoomType)random.Next(1, 5),
                BathroomsCount = random.Next(1, 3),
                Floor = random.Next(1, 15)
            };

            room.Number = int.Parse($"{room.Floor}{random.Next(1, 99)}");
            room.Name = $"Номер {room.Number}";

            return room;
        }

        private static List<Bedroom> GenerateRandomBedroomList(double area)
        {
            List<Bedroom> ret = new();

            var random = new Random();

            var count = random.Next(1, 5);

            double sumOfArea = 0;

            for (int i = 0; i < count; i++)
            {
                double bedroomArea;

                if (i < count - 1)
                {
                    bedroomArea = (area / count) * (random.NextDouble() * 0.2 + 1);                   

                    sumOfArea += bedroomArea;
                }
                else
                {
                    bedroomArea = area - sumOfArea;
                }

                bedroomArea = (double)(int)(bedroomArea * 100) / 100;

                var bedroom = new Bedroom()
                {
                    Area = bedroomArea
                };

                ret.Add(bedroom);
            }

            return ret;
        }

        private static List<Bed> GenerateRandomBedList()
        {
            var random = new Random();

            List<Bed> ret = new();

            var count = random.Next(1, 3);

            for (int i = 0; i < count; i++)
            {
                var bed = new Bed()
                {
                    Capacity = random.Next(1, 3)
                };

                ret.Add(bed);
            }

            return ret;
        }

        private static Customer GenerateRandomCustomer()
        {
            var random = new Random();

            var utcNow = DateTime.UtcNow;

            var ageYears = random.Next(1, 100);
            var ageDays = random.Next(1, 365);

            var birthDate = utcNow.AddYears(-ageYears).AddDays(ageDays).Date;

            Customer ret = new()
            {
                BirthDate = birthDate,
                FullName = GenerateRandomFullName()
            };

            return ret;
        }

        private static string[] NAMES = new string[] 
        { 
            "Иван",
            "Максим",
            "Димон",
            "Егор",
            "Андрей",
            "Аркадий",
            "Руслан",
            "Денис"
        };

        private static string[] SURNAMES = new string[]
        {
            "Петров",
            "Иванов",
            "Сидоров",
            "Микушов",
            "Денисов",
            "Андреев",
            "Снегов",
            "Жук",
            "Кружков"
        };

        private static string[] SECOND_NAMES = new string[]
        {
            "Денисович",
            "Русланович",
            "Аркадьевич",
            "Андреевич",
            "Егорович",
            "Дмитриевич",
            "Максимович",
            "Иванович"
        };

        private static string GenerateRandomFullName()
        {
            var random = new Random();

            var fullName = $"{SURNAMES[random.Next(0, SURNAMES.Length)]} " +
                $"{NAMES[random.Next(0, NAMES.Length)]} " +
                $"{SECOND_NAMES[random.Next(0, SECOND_NAMES.Length)]}";

            return fullName;
        }

        private static Accomodation GenerateRandomAccomodation(int roomId)
        {
            var random = new Random();

            var customers = HostelDbContext
                .GetInstance()
                .GetCustomersAsync()
                .GetAwaiter()
                .GetResult();

            var onDate = DateTime.UtcNow.Date;

            var fromDateOffset = random.Next(0, 20) - 10;
            var accomodationLength = random.Next(1, 20);

            var acc = new Accomodation()
            {
                RoomId = roomId,
                CustomerId = customers[random.Next(0, customers.Count)].Id,
                FromDate = onDate.AddDays(fromDateOffset),
                ToDate = onDate.AddDays(fromDateOffset).AddDays(accomodationLength)
            };

            return acc;
        }
    }
}
