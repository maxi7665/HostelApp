using HostelApp.Entities;
using HostelApp.Persistence;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace HostelApp
{
    public partial class AccomodationForm : Form
    {
        private readonly Customer? _defaultCustomer;
        private readonly Customer? _filterCustomer;
        private readonly Room? _defaultRoom;
        private readonly Room? _filterRoom;

        public AccomodationForm(
            Customer? defaultCustomer = null,
            Customer? filterCustomer = null,
            Room? defaultRoom = null,
            Room? filterRoom = null)
        {
            InitializeComponent();

            _defaultCustomer = defaultCustomer;
            _filterCustomer = filterCustomer;
            _defaultRoom = defaultRoom;
            _filterRoom = filterRoom;

            if (_filterRoom != null)
            {
                SearchRoomField.Enabled = false;
                RoomComboBox.Enabled = false;
                _defaultRoom = _filterRoom;
            }

            if (_filterCustomer != null)
            {
                SearchNameField.Enabled = false;
                CustomerComboBox.Enabled = false;
                _defaultCustomer = _filterCustomer;
            }

            SetCustomersComboBoxSource();
            SetRoomsComboBoxSource();
            ExecuteAccomodationQuery();
        }

        private void ExecuteAccomodationQuery()
        {
            var accomodations = HostelDbContext
                .GetInstance()
                .GetAccomodationsAsync()
                .GetAwaiter()
                .GetResult()
                .Where(acc => (acc.CustomerId == _filterCustomer?.Id
                    || _filterCustomer == null)
                    && (acc.RoomId == _filterRoom?.Id
                    || _filterRoom == null))
                .ToList();

            AccomodationGrid.DataSource = accomodations;
        }

        private void SearchNameField_TextChanged(object sender, EventArgs e)
        {
            SetCustomersComboBoxSource();
        }

        private void SetCustomersComboBoxSource()
        {
            var searchText = SearchNameField.Text.ToLower();

            var customers = HostelDbContext
                .GetInstance()
                .GetCustomersAsync()
                .GetAwaiter()
                .GetResult()
                .Where(c => c.FullName.ToLower().Contains(searchText)
                    || c.Id.ToString().ToLower().Contains(searchText)
                    || string.IsNullOrWhiteSpace(searchText))
                .ToList();

            CustomerComboBox.Items.Clear();
            CustomerComboBox.Items.AddRange(customers.ToArray());

            if (string.IsNullOrWhiteSpace(searchText)
                && _defaultCustomer != null
                && CustomerComboBox.Items.Contains(_defaultCustomer))
            {
                CustomerComboBox.SelectedItem = _defaultCustomer;
            }
        }

        private void SetRoomsComboBoxSource()
        {
            var searchText = SearchRoomField.Text.ToLower();

            var rooms = HostelDbContext
                .GetInstance()
                .GetRoomsAsync()
                .GetAwaiter()
                .GetResult()
                .Where(c => c.Name.ToLower().Contains(searchText)
                    || c.Number.ToString().ToLower().Contains(searchText)
                    || c.RoomType.ToString().ToLower().Contains(searchText)
                    || c.Id.ToString().ToLower().Contains(searchText)
                    || string.IsNullOrWhiteSpace(searchText))
                .ToList();

            RoomComboBox.Items.Clear();
            RoomComboBox.Items.AddRange(rooms.ToArray());

            if (string.IsNullOrWhiteSpace(searchText)
                && _defaultRoom != null
                && RoomComboBox.Items.Contains(_defaultRoom))
            {
                RoomComboBox.SelectedItem = _defaultRoom;
            }
        }

        private void RoomSearchField_TextChanged(object sender, EventArgs e)
        {
            SetRoomsComboBoxSource();
        }

        private void CreateAccomodationButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccomodation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }

        }

        private void CreateAccomodation()
        {
            var room = RoomComboBox.SelectedItem as Room
                ?? throw new NullReferenceException("Номер не выбран");

            var customer = CustomerComboBox.SelectedItem as Customer
                ?? throw new NullReferenceException("Гость не выбран");

            var fromDate = FromDatePicker.Value;
            var toDate = ToDatePicker.Value;

            using var session = HostelDbContext.GetInstance().BeginSession();

            var acc = HostelDbContext
                .GetInstance()
                .CreateRoomAccomodationAsync(
                    room.Id,
                    fromDate,
                    toDate,
                    customer.Id)
                .GetAwaiter()
                .GetResult();

            ExecuteAccomodationQuery();

            foreach (DataGridViewRow item in AccomodationGrid.Rows)
            {
                if (item.DataBoundItem is Accomodation gridAcc
                    && gridAcc.Id == acc.Id)
                {
                    AccomodationGrid.ClearSelection();
                    AccomodationGrid.CurrentCell = item.Cells[0];

                    item.Cells[0].Selected = true;

                    break;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteAccomodation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private void DeleteAccomodation()
        {
            var result = MessageBox.Show(
                this,
                "Удалить заселение?",
                "Внимание",
                MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
            {
                return;
            }

            var acc = AccomodationGrid.CurrentRow.DataBoundItem as Accomodation
                ?? throw new NullReferenceException("Заселение не выбрано");

            using var session = HostelDbContext.GetInstance().BeginSession();

            HostelDbContext.GetInstance().DeleteAccomodationAsync(acc.Id).GetAwaiter().GetResult();

            ExecuteAccomodationQuery();
        }
    }
}
