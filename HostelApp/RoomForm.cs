using HostelApp.Entities;
using HostelApp.Entities.Codes;
using HostelApp.Extensions;
using HostelApp.Persistence;
using HostelApp.Requirements;

namespace HostelApp
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private async Task ExecuteBedroomQuery()
        {
            var dataSource = Enumerable.Empty<Bedroom>().ToList();

            if (RoomGrid.CurrentRow != null)
            {
                var room = RoomGrid.CurrentRow.DataBoundItem as Room;

                if (room != null)
                {
                    dataSource = await HostelDbContext
                        .GetInstance()
                        .GetRoomBedroomsAsync(room.Id);
                }
            }

            BedroomGrid.DataSource = dataSource;
        }

        private async Task ExecuteRoomQuery()
        {
            var requirementSet = new RequirementSetBuilder()
                .AddRoomTypeRequirement(
                    new RoomType[] { (RoomType)RoomTypeField.SelectedIndex })
                .AddFloorNumberRequirement(
                    (int)MinFloorNumberField.Value,
                    (int)MaxFloorNumberField.Value)
                .AddAreaRequirement(
                    (double)MinAreaField.Value,
                    (double)MaxAreaField.Value)
                .AddCapacityRequrement(
                    (int)MinCapacityField.Value,
                    (int)MaxCapacityField.Value)
                .AddBathroomRequirement(
                    (int)MinBathroomNumberField.Value,
                    (int)MaxBathroomNumberField.Value)
                .AddBedRequirement(
                    (int)OnePlaceBedNumberField.Value,
                    (int)TwoPlaceBedNumberField.Value)
                .AddBedroomRequirement(
                    (int)MinBedroomNumberField.Value,
                    (int)MaxBedroomNumberField.Value)
                .BuildRequirementSet();

            var roomProvider = new RequirementRoomProvider(requirementSet);

            var fromDate = VacantCalendar.SelectionStart;
            var toDate = VacantCalendar.SelectionEnd;

            List<Room> rooms;

            if (fromDate != DateTime.MinValue
                && toDate != DateTime.MinValue)
            {
                rooms = await roomProvider.GetVacantRoomsAsync(
                    fromDate,
                    toDate);
            }
            else
            {
                rooms = await roomProvider.GetRoomsAsync();
            }

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

        private void RoomGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ExecuteBedroomQuery().GetAwaiter().GetResult();
        }

        private void RoomGrid_SelectionChanged(object sender, EventArgs e)
        {
            ExecuteBedroomQuery().GetAwaiter().GetResult();
        }
    }
}