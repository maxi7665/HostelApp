using HostelApp.Entities;
using HostelApp.Entities.Codes;
using HostelApp.Extensions;
using HostelApp.Persistence;
using HostelApp.Requirements;

namespace HostelApp
{
    public partial class RoomForm : Form
    {
        private Customer? _selectedCustomer = null;

        public void SetSelectedCustomer(Customer? selectedCustomer)
        {
            _selectedCustomer = selectedCustomer;

            if (_selectedCustomer != null)
            {
                CurrentCustomerLabel.Text =
                    $"Текущий гость: {_selectedCustomer.FullName} ({_selectedCustomer.Id})";
            }
            else
            {
                CurrentCustomerLabel.Text =
                    $"Текущий гость: не выбран";
            }
        }

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

        private async Task ExecuteBedQuery()
        {
            var dataSource = Enumerable.Empty<Bed>().ToList();

            if (BedroomGrid.CurrentRow != null)
            {
                var bedroom = BedroomGrid.CurrentRow.DataBoundItem as Bedroom;

                if (bedroom != null)
                {
                    dataSource = await HostelDbContext
                        .GetInstance()
                        .GetBedroomBedsAsync(bedroom.Id);
                }
            }

            BedGrid.DataSource = dataSource;
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

        private void BedroomGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ExecuteBedQuery().GetAwaiter().GetResult();
        }

        private void BedroomGrid_SelectionChanged(object sender, EventArgs e)
        {
            ExecuteBedQuery().GetAwaiter().GetResult();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            var customers = new CustomersForm();

            customers.ShowDialog(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var currentGrid = GetActiveGrid();

            if (currentGrid == null)
            {
                MessageBox.Show(this, "Данные не выбраны", "Ошибка");

                return;
            }

            var currentObject = currentGrid.CurrentRow.DataBoundItem;

            if (currentObject != null)
            {
                var edit = new EditEntityForm(currentObject);                

                var result = edit.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    using (var session = HostelDbContext.GetInstance().BeginSession())
                    {
                        if (currentGrid == RoomGrid)
                        {
                            HostelDbContext.GetInstance().UpdateRoomAsync((Room)currentObject)
                                .GetAwaiter().GetResult();
                        }
                        else if (currentGrid == BedroomGrid)
                        {
                            HostelDbContext.GetInstance().UpdateBedroomAsync((Bedroom)currentObject)
                                .GetAwaiter().GetResult();
                        }
                        else if (currentGrid == BedGrid)
                        {
                            HostelDbContext.GetInstance().UpdateBedAsync((Bed)currentObject)
                                .GetAwaiter().GetResult();
                        }
                    }

                    currentGrid.Update();
                    currentGrid.Refresh();
                }
            }
            else
            {
                MessageBox.Show(this, "Данные не выбраны", "Ошибка");
            }
        }

        private DataGridView? GetActiveGrid()
        {
            if (TabControl.SelectedTab == RoomTab)
            {
                return RoomGrid;
            }
            else if (TabControl.SelectedTab == BedroomTab)
            {
                return BedroomGrid;
            }
            else if (TabControl.SelectedTab == BedTab)
            {
                return BedGrid;
            }

            return null;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var currentGrid = GetActiveGrid();

            if (currentGrid == null)
            {
                MessageBox.Show(this, "Данные не выбраны", "Ошибка");

                return;
            }

            object? currentObject = null;

            if (currentGrid == RoomGrid)
            {
                currentObject = new Room();
            }
            else if (currentGrid == BedroomGrid)
            {
                var room = RoomGrid.CurrentRow.DataBoundItem as Room;

                currentObject = new Bedroom()
                {
                    RoomId = room?.Id ?? 0
                };
            }
            else if (currentGrid == BedGrid)
            {
                var bedroom = BedroomGrid.CurrentRow.DataBoundItem as Bedroom;

                currentObject = new Bed()
                {
                    BedroomId = bedroom?.Id ?? 0
                };
            }

            if (currentObject != null)
            {
                var edit = new EditEntityForm(currentObject);

                var result = edit.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    using (var session = HostelDbContext.GetInstance().BeginSession())
                    {
                        if (currentGrid == RoomGrid)
                        {
                            HostelDbContext.GetInstance().AddRoomAsync((Room)currentObject).GetAwaiter().GetResult();
                        }
                        else if (currentGrid == BedroomGrid)
                        {
                            HostelDbContext.GetInstance().AddBedroomAsync((Bedroom)currentObject).GetAwaiter().GetResult();
                        }
                        else if (currentGrid == BedGrid)
                        {
                            HostelDbContext.GetInstance().AddBedAsync((Bed)currentObject).GetAwaiter().GetResult();
                        }
                    }

                    if (currentGrid == RoomGrid)
                    {
                        ExecuteRoomQuery().GetAwaiter().GetResult();
                    }
                    else if (currentGrid == BedroomGrid)
                    {
                        ExecuteBedroomQuery().GetAwaiter().GetResult();
                    }
                    else if (currentGrid == BedGrid)
                    {
                        ExecuteBedQuery().GetAwaiter().GetResult();
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Данные не выбраны", "Ошибка");
            }
        }
    }
}