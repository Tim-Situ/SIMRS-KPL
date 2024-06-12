using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PembayaranView
{
    public partial class PembayaranDisplay : Form
    {
        private readonly PembayaranManager _pembayaranManager;
        private readonly MainDisplay _mainDisplay;
        private List<Pembayaran> _listPembayaran { get; set; }


        public PembayaranDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pembayaranManager = new();
        }

        private void PembayaranDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();   
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Pembayaran>> response = await _pembayaranManager.GetPembayaran();
                _listPembayaran = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewPembayaran> gridViewPembayaran = _listPembayaran.Select(pembayaran =>
                {
                    return new GridViewPembayaran(
                        pembayaran.kode,
                        pembayaran.pemeriksaan.tanggal,
                        pembayaran.pemeriksaan.pasien.nama,
                        pembayaran.pemeriksaan.dokter.nama,
                        pembayaran.uangBayar.ToString()
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewPembayaran.Count == 0)
                {
                    TabelPembayaran.Hide();
                    LabelDataKosong.Text = "Data pembayaran kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelPembayaran.InvokeRequired)
                    {
                        TabelPembayaran.Invoke(new Action(() => TabelPembayaran.DataSource = gridViewPembayaran));
                    }
                    else
                    {
                        TabelPembayaran.DataSource = gridViewPembayaran;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewPembayaran
        {
            public string kode { get; set; }
            public string tanggal { get; set; }
            public string namaPasien { get; set; }
            public string namaDokter { get; set; }
            public string uangBayar { get; set; }

            public GridViewPembayaran(string kode, string tanggal, string namaPasien, string namaDokter, string uangBayar)
            {
                this.kode = kode;
                this.tanggal = tanggal;
                this.namaPasien = namaPasien;
                this.namaDokter = namaDokter;
                this.uangBayar = uangBayar;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new PembayaranTambahDisplay(_mainDisplay));
        }

        private async void TabelPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode;
            switch (TabelPembayaran.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    kode = _listPembayaran[e.RowIndex].kode;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Pembayaran> response = await _pembayaranManager.DeletePembayaran(kode);
                        MessageBox.Show(response.message);
                    }
                    break;
            }

            await LoadDataAsync();
        }

        private void TabelPembayaran_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayUtils.NomorUrut(TabelPembayaran);
        }
    }
}
