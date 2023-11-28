using HostelApp.Entities;
using HostelApp.Exceptions;
using HostelApp.Persistence;

namespace HostelApp
{
    public partial class CustomersForm : Form
    {
        private Customer? currentCustomer;

        private async Task ExecuteCustomersQuery()
        {
            var dataSource = await HostelDbContext.GetInstance().GetCustomersAsync();

            CustomersGrid.DataSource = dataSource;

            if (currentCustomer != null)
            {
                foreach (var item in CustomersGrid.Rows)
                {
                    if (item is DataGridViewRow row
                        && row.DataBoundItem is Customer customer
                        && customer.Id == currentCustomer.Id)
                    {
                        CustomersGrid.ClearSelection();

                        row.Selected = true;

                        CustomersGrid.CurrentCell = row.Cells[0];

                        break;
                    }
                }
            }
        }

        public CustomersForm()
        {
            InitializeComponent();

            ExecuteCustomersQuery().GetAwaiter().GetResult();
        }

        private void CustomersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomersGrid.CurrentRow != null
                && CustomersGrid.CurrentRow.DataBoundItem is Customer customer)
            {
                NameField.Text = customer.FullName;
                BirthdayPicker.Value = customer.BirthDate;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = ReadCustomerFromForm();

                HostelDbContext.GetInstance()
                    .AddCustomerAsync(customer)
                    .GetAwaiter()
                    .GetResult();

                if (customer.Id > 0)
                {
                    currentCustomer = customer;
                }

                ExecuteCustomersQuery().GetAwaiter().GetResult();
            }
            catch (PersistenceException ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private Customer ReadCustomerFromForm()
        {
            var customer = new Customer()
            {
                FullName = NameField.Text,
                BirthDate = BirthdayPicker.Value
            };

            if (string.IsNullOrWhiteSpace(customer.FullName))
            {
                throw new PersistenceException("Имя не введено");
            }

            if (customer.BirthDate < DateTime.UtcNow.AddYears(-150)
                || customer.BirthDate > DateTime.UtcNow)
            {
                throw new PersistenceException("Неправильная дата рождения");
            }

            return customer;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCustomer = GetCurrentCustomer() 
                    ?? throw new PersistenceException("Гость не выбран!");

                var customer = ReadCustomerFromForm();

                customer.Id = selectedCustomer.Id;

                HostelDbContext.GetInstance()
                    .UpdateCustomerAsync(customer)
                    .GetAwaiter()
                    .GetResult();

                if (customer.Id > 0)
                {
                    currentCustomer = customer;
                }

                ExecuteCustomersQuery().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }

        private Customer? GetCurrentCustomer()
        {
            var selectedCustomer = CustomersGrid.CurrentRow?.DataBoundItem as Customer;

            return selectedCustomer;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCustomer = GetCurrentCustomer()
                    ?? throw new PersistenceException("Гость не выбран!");

                HostelDbContext.GetInstance()
                    .DeleteCustomerAsync(selectedCustomer.Id)
                    .GetAwaiter()
                    .GetResult();

                ExecuteCustomersQuery().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка");
            }
        }
    }
}
