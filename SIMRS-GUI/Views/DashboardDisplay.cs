using Microsoft.AspNetCore.Mvc;
using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class DashboardDisplay : Form
    {
        private PasienManager controller = new();
        private List<Pasien> listPasien { get; set; }

        public DashboardDisplay()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void DashboardDisplay_Load(object sender, EventArgs e)
        {

        }
        private async Task LoadDataAsync()
        {
            try
            {
                ApiResponse<List<Pasien>> response = await controller.GetPasien();
                listPasien = response.data;


                if (TabelPasien.InvokeRequired)
                {
                    TabelPasien.Invoke(new Action(() => TabelPasien.DataSource = listPasien));
                }
                else
                {
                    TabelPasien.DataSource = listPasien;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }
    }
}
