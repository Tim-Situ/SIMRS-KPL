using Microsoft.AspNetCore.Mvc;
using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class DashboardDisplay : Form
    {
        private readonly PasienManager _pasienManager;
        private readonly DokterManager _dokterManager;
        private readonly PoliManager _poliManager;
        private readonly PembayaranManager _pembayaranManager;

        public DashboardDisplay()
        {
            InitializeComponent();
            TopLevel = false;
            _pasienManager = new();
            _dokterManager = new();
            _poliManager = new();
            _pembayaranManager = new();
        }

        private void DashboardDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                ApiResponse<List<Pasien>> responsePasien = await _pasienManager.GetPasien();
                ApiResponse<List<Dokter>> responseDokter = await _dokterManager.GetDokter();
                ApiResponse<List<Poli>> responsePoli = await _poliManager.GetPoli();
                ApiResponse<List<Pembayaran>> responsePembayaran = await _pembayaranManager.GetPembayaran();
                int _jumlahPasien = responsePasien.data.Count;
                int _jumlahDokter = responseDokter.data.Count;
                int _jumlahPoli = responsePoli.data.Count;
                int _jumlahPembayaran = responsePembayaran.data.Count;

                if (LabelJumlahPasien.InvokeRequired || LabelJumlahDokter.InvokeRequired || LabelJumlahPoli.InvokeRequired ||  LabelJumlahPembayaran.InvokeRequired)
                {
                    LabelJumlahPasien.Invoke(new Action(() => LabelJumlahPasien.Text = _jumlahPasien.ToString() + " Pasien"));
                    LabelJumlahDokter.Invoke(new Action(() => LabelJumlahDokter.Text = _jumlahDokter.ToString() + " Pasien"));
                    LabelJumlahPoli.Invoke(new Action(() => LabelJumlahPoli.Text = _jumlahPoli.ToString() + " Pasien"));
                    LabelJumlahPembayaran.Invoke(new Action(() => LabelJumlahPembayaran.Text = _jumlahPembayaran.ToString() + " Pasien"));
                }
                else
                {
                    LabelJumlahPasien.Text = _jumlahPasien.ToString() + " Pasien";
                    LabelJumlahDokter.Text = _jumlahDokter.ToString() + " Dokter";
                    LabelJumlahPoli.Text = _jumlahPoli.ToString() + " Poli";
                    LabelJumlahPembayaran.Text = _jumlahPembayaran.ToString() + " Pembayaran";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }
    }
}
