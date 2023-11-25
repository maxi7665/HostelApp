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

        private async Task ExecuteRoomQuery()
        {
            var requirementSet = new RequirementSetBuilder()
                .AddRoomTypeRequirement(
                    new RoomType[] { (RoomType)RoomTypeField.SelectedIndex })
                .AddFloorNumberRequirement(
                    (int)MinFloorNumberField.Value,
                    (int)MaxFloorNumberField.Value)
                .BuildRequirementSet();

            var roomProvider = new RequirementRoomProvider(requirementSet);

            var rooms = await roomProvider.GetRoomsAsync();

            RoomGrid.DataSource = rooms;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            var context = HostelDbContext.GetInstance();

            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                using var session = context.BeginSession();

                context.SetDatabaseFullFileName(Path.GetTempFileName());

                context.GenerateTestDataSet().GetAwaiter().GetResult();
            }

            ExecuteRoomQuery().GetAwaiter().GetResult();

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
            ExecuteRoomQuery().GetAwaiter().GetResult();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            ExecuteRoomQuery().GetAwaiter().GetResult();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            FilterChanged(sender, e);
        }

        private void RoomGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}