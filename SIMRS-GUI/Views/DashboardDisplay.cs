using Microsoft.AspNetCore.Mvc;
using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class DashboardDisplay : Form
    {
        private PasienManager _pasienManager = new();
        private int _jumlahPasien = 0;

        public DashboardDisplay()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void DashboardDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                ApiResponse<List<Pasien>> response = await _pasienManager.GetPasien();
                _jumlahPasien = response.data.Count;

                if (LabelJumlahPasien.InvokeRequired)
                {
                    LabelJumlahPasien.Invoke(new Action(() => LabelJumlahPasien.Text = _jumlahPasien.ToString() + " Pasien"));
                }
                else
                {
                    LabelJumlahPasien.Text = _jumlahPasien.ToString() + " Pasien";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }
    }
}
