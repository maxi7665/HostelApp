using HostelApp.Entities;
using HostelApp.Persistence;
using System.Diagnostics;
using System.Drawing;

namespace HostelApp.Extensions
{
    public static class HostelDbContextExtensions
    {
        public static async Task GenerateTestDataSet(this HostelDbContext context)
        {
            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                var fileName = Path.GetRandomFileName();

                context.SetDatabaseFullFileName(fileName);
            }

            using var writeSession = context.BeginSession();

            var rooms = await context.GetRoomsAsync();

            rooms.Clear();

            for (int i = 0; i <= 100; i ++)
            {
                var room = GenerateRandomRoom();

                await context.AddRoomAsync(room);
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
    }
}
