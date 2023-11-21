using HostelApp.Extensions;
using HostelApp.Persistence;

namespace HostelApp
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private async Task BindData()
        {
            var context = HostelDbContext.GetInstance();

            if (string.IsNullOrWhiteSpace(context.GetDatabaseFullFileName()))
            {
                context.SetDatabaseFullFileName(Path.GetTempFileName());

                await context.GenerateTestDataSet();
            }

            dataGridView1.DataSource = await context.GetRoomsAsync();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            BindData().GetAwaiter().GetResult();
        }
    }
}