using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class DashboardDisplay : Form
    {
        PasienService controller = new();
        public List<Pasien> listPasien { get; set; }

        public DashboardDisplay()
        {
            InitializeComponent();
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var response = await controller.GetPasien();
                listPasien = response.data;

                if (dataGridView1.InvokeRequired)
                {
                    dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = listPasien));
                }
                else
                {
                    dataGridView1.DataSource = listPasien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }
    }
}
