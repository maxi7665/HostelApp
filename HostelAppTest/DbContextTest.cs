using HostelApp.Persistence;
using HostelApp.Extensions;
using System.Text.Json;

namespace HostelAppTest
{
    [TestClass]
    public class DbContextTest
    {
        [TestMethod]
        public async Task RandomTest()
        {
            var context = HostelDbContext.GetInstance();

            var tempFile = Path.GetTempFileName();

            context.SetDatabaseFullFileName(tempFile);

            await context.GenerateTestDataSetAsync();

            Console.WriteLine(
                JsonSerializer.Serialize(
                    await context.GetRoomsAsync()));
        }
    }
}