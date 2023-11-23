using HostelApp.Entities.Codes;
using HostelApp.Extensions;
using HostelApp.Persistence;
using HostelApp.Requirements;
using System.Data;

namespace HostelApp
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private async Task ExecuteQuery()
        {
            var requirementSet = new RequirementSetBuilder()
                .AddRoomTypeRequirement(
                    new RoomType[] { (RoomType)RoomTypeField.SelectedIndex })
                .AddFloorNumberRequirement(
                    (int)MinFloorNumberField.Value,
                    (int)MaxFloorNumberField.Value)
                .BuildRequirementSet();



            var roomType = (RoomType)RoomTypeField.SelectedIndex;

            var context = HostelDbContext.GetInstance();

            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                context.SetDatabaseFullFileName(Path.GetTempFileName());

                await context.GenerateTestDataSet();
            }

            var rooms = await context.GetRoomsAsync();

            rooms = rooms.Where(r =>
                r.RoomType == roomType
                || roomType == RoomType.Все).ToList();

            RoomGrid.DataSource = rooms;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            ExecuteQuery().GetAwaiter().GetResult();

            InitFilters();
        }

        private void InitFilters()
        {
            var enumValues = Enum
                .GetValues<RoomType>();

            RoomTypeField.DataSource = enumValues;
        }

        private void RoomTypeField_SelectedValueChanged(object sender, EventArgs e)
        {
            ExecuteQuery().GetAwaiter().GetResult();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            ExecuteQuery().GetAwaiter().GetResult();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void RoomGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}