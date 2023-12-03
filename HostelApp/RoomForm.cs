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
                    1,
                    (int)OnePlaceBedNumberField.Value)
                .AddBedRequirement(
                    2,
                    (int)TwoPlaceBedNumberField.Value)
                .AddBedroomRequirement(
                    (int)MinBedroomNumberField.Value,
                    (int)MaxBedroomNumberField.Value)
                .BuildRequirementSet();

            var roomProvider = new RequirementRoomProvider(requirementSet);

            var fromDate = VacantCalendar.SelectionStart;
            var toDate = VacantCalendar.SelectionEnd;

            List<Room> rooms;

            if (IsOnlyVacantField.Checked
                && fromDate != DateTime.MinValue
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

        private void RoomForm_Load(object sender, EventArgs e)
        {
            var context = HostelDbContext.GetInstance();

            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                using var session = context.BeginSession();

                context.SetDatabaseFullFileName(Path.GetTempFileName());

                context.GenerateTestDataSetAsync().GetAwaiter().GetResult();
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
                            HostelDbContext.GetInstance()
                                .AddRoomAsync((Room)currentObject).Wait();
                        }
                        else if (currentGrid == BedroomGrid)
                        {
                            HostelDbContext.GetInstance()
                                .AddBedroomAsync((Bedroom)currentObject).Wait();
                        }
                        else if (currentGrid == BedGrid)
                        {
                            HostelDbContext.GetInstance()
                                .AddBedAsync((Bed)currentObject).Wait();
                        }
                    }

                    if (currentGrid == RoomGrid)
                    {
                        ExecuteRoomQuery().Wait();
                    }
                    else if (currentGrid == BedroomGrid)
                    {
                        ExecuteBedroomQuery().Wait();
                    }
                    else if (currentGrid == BedGrid)
                    {
                        ExecuteBedQuery().Wait();
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Данные не выбраны", "Ошибка");
            }
        }

        private void AccomodationButton_Click(object sender, EventArgs e)
        {
            var room = RoomGrid.CurrentRow.DataBoundItem as Room;

            var form = new AccomodationForm(
                defaultCustomer: _selectedCustomer,
                defaultRoom: room);

            form.ShowDialog(this);
        }

        private void RoomAccomodationButton_Click(object sender, EventArgs e)
        {
            var room = RoomGrid.CurrentRow.DataBoundItem as Room;

            var form = new AccomodationForm(
                filterRoom: room,
                defaultCustomer: _selectedCustomer);

            form.ShowDialog(this);
        }

        private void SelectDbButton_Click(object sender, EventArgs e)
        {
            var context = HostelDbContext.GetInstance();
            var prevFileName = context.GetDatabaseFullFileName();

            try
            {               
                context.SaveChanges().Wait();
                context.SelectDatabaseFile().Wait();

                ExecuteRoomQuery().Wait();
            }
            catch
            {
                context.SetDatabaseFullFileName(prevFileName);
                ExecuteRoomQuery().Wait();

                MessageBox.Show(this, "Не удалось открыть файл", "Ошибка");
            }
        }

        private void SaveDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                var context = HostelDbContext.GetInstance();

                context.CopyDatabaseFile().Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void ClearDbButton_Click(object sender, EventArgs e)
        {
            try
            {
                var context = HostelDbContext.GetInstance();

                context.ClearDatabaseFile().Wait();

                ExecuteRoomQuery().Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void TestBdButton_Click(object sender, EventArgs e)
        {
            try
            {
                var context = HostelDbContext.GetInstance();

                context.ClearDatabaseFile().Wait();
                context.GenerateTestDataSetAsync().Wait();
                context.SaveChanges().Wait();

                ExecuteRoomQuery().Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void IsVacantField_CheckedChanged(object sender, EventArgs e)
        {
            var value = IsOnlyVacantField.Checked;

            if (value)
            {
                VacantCalendar.Enabled = true;
            }
            else
            {
                VacantCalendar.Enabled = false;
            }

            ExecuteRoomQuery().Wait();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var context = HostelDbContext.GetInstance();

                if (TabControl.SelectedTab == RoomTab)
                {
                    var entity = RoomGrid.CurrentRow.DataBoundItem as Room
                        ?? throw new NullReferenceException("Элемент для удаления не выбран");

                    context.DeleteRoomAsync(entity.Id).Wait();
                }
                else if (TabControl.SelectedTab == BedroomTab)
                {
                    var entity = BedroomGrid.CurrentRow.DataBoundItem as Bedroom
                        ?? throw new NullReferenceException("Элемент для удаления не выбран");

                    context.DeleteBedroomAsync(entity.Id).Wait();
                }
                else if (TabControl.SelectedTab == BedTab)
                {
                    var entity = BedGrid.CurrentRow.DataBoundItem as Bed
                        ?? throw new NullReferenceException("Элемент для удаления не выбран");

                    context.DeleteBedAsync(entity.Id).Wait();
                }
                else
                {
                    throw new ApplicationException("Элемент для удаления не выбран");
                }

                ExecuteRoomQuery().Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }
    }
}