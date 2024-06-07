using SIMRS_API;
using SIMRS_GUI.Services;
using SIMRS_GUI.Views.DokterView;
using SIMRS_GUI.Views.ObatView;

namespace SIMRS_GUI.Views.PemeriksaanView
{
    public partial class PemeriksaanDisplay : Form
    {
        private readonly PemeriksaanManager _pemeriksaanManager;
        private readonly MainDisplay _mainDisplay;
        private List<Pemeriksaan> _listPemeriksaan { get; set; }

        public PemeriksaanDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pemeriksaanManager = new();
        }

        private void PemeriksaanDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Pemeriksaan>> response = await _pemeriksaanManager.GetPemeriksaan();
                _listPemeriksaan = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewPemeriksaan> gridViewPemeriksaan = _listPemeriksaan.Select(pemeriksaan =>
                {
                    return new GridViewPemeriksaan(
                        pemeriksaan.kode,
                        pemeriksaan.pasien.nama,
                        pemeriksaan.dokter.nama,
                        pemeriksaan.tanggal,
                        pemeriksaan.tinggiBadan.ToString(),
                        pemeriksaan.beratBadan.ToString(),
                        pemeriksaan.tekananDarah,
                        pemeriksaan.keluhan,
                        pemeriksaan.diagnosa,
                        pemeriksaan.obat.nama
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewPemeriksaan.Count == 0)
                {
                    TabelPemeriksaan.Hide();
                    LabelDataKosong.Text = "Data pemeriksaan kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelPemeriksaan.InvokeRequired)
                    {
                        TabelPemeriksaan.Invoke(new Action(() => TabelPemeriksaan.DataSource = gridViewPemeriksaan));
                    }
                    else
                    {
                        TabelPemeriksaan.DataSource = gridViewPemeriksaan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewPemeriksaan
        {
            public string kode { get; set; }
            public string namaPasien { get; set; }
            public string namaDokter { get; set; }
            public string tanggal { get; set; }
            public string tinggiBadan { get; set; }
            public string beratBadan { get; set; }
            public string tekananDarah { get; set; }
            public string keluhan { get; set; }
            public string diagnosa { get; set; }
            public string namaObat { get; set; }

            public GridViewPemeriksaan(string kode, string namaPasien, string namaDokter, string tanggal, string tinggiBadan, string beratBadan, string tekananDarah, string keluhan, string diagnosa, string namaObat)
            {
                this.kode = kode;
                this.namaPasien = namaPasien;
                this.namaDokter = namaDokter;
                this.tanggal = tanggal;
                this.tinggiBadan = tinggiBadan;
                this.beratBadan = beratBadan;
                this.tekananDarah = tekananDarah;
                this.keluhan = keluhan;
                this.diagnosa = diagnosa;
                this.namaObat = namaObat;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new PemeriksaanTambahDisplay(_mainDisplay));
        }

        private async void TabelPemeriksaan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode;
            switch (TabelPemeriksaan.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    kode = _listPemeriksaan[e.RowIndex].kode;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Pemeriksaan> response = await _pemeriksaanManager.DeletePemeriksaan(kode);
                        MessageBox.Show(response.message);
                    }
                    break;
                case "Edit":
                    _mainDisplay.ShowDisplay(new PemeriksaanEditDisplay(_mainDisplay, _listPemeriksaan[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }
    }
}
