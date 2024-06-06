using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PasienView
{
    public partial class PasienDisplay : Form
    {
        private readonly PasienManager _pasienManager;
        private readonly MainDisplay _mainDisplay;
        private List<Pasien> _listPasien { get; set; }

        public PasienDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pasienManager = new();
        }

        private void PasienDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Pasien>> response = await _pasienManager.GetPasien();
                _listPasien = response.data;

                // Ambil datanya yang mau ditampilin saja.
                List<GridViewPasien> gridViewPasien = _listPasien.Select(data =>
                {
                    return new GridViewPasien(
                        data.nik,
                        data.nama,
                        data.tglLahir,
                        data.noHp,
                        data.jnsKelamin.ToString(),
                        data.alamat
                        );
                    
                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewPasien.Count == 0)
                {
                    TabelPasien.Hide();
                    LabelDataKosong.Text = "Data pasien kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelPasien.InvokeRequired)
                    {
                        TabelPasien.Invoke(new Action(() => TabelPasien.DataSource = gridViewPasien));
                    }
                    else
                    {
                        TabelPasien.DataSource = gridViewPasien;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewPasien
        {
            public string nik { get; set; }
            public string nama { get; set; }
            public string tanggalLahir { get; set; }
            public string noHP { get; set; }
            public string jenisKelamin { get; set; }
            public string alamat { get; set; }

            public GridViewPasien(string nik, string nama, string tanggalLahir, string noHP, string jenisKelamin, string alamat)
            {
                this.nik = nik;
                this.nama = nama;
                this.tanggalLahir = tanggalLahir;
                this.noHP = noHP;
                this.jenisKelamin = jenisKelamin;
                this.alamat = alamat;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new PasienTambahDisplay(_mainDisplay));
        }

        private async void TabelPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nikSelected;
            switch (TabelPasien.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    nikSelected = _listPasien[e.RowIndex].nik;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Pasien> response = await _pasienManager.DeletePasien(nikSelected);
                        MessageBox.Show(response.message);
                    }
                    break;
                case "Edit":
                    _mainDisplay.ShowDisplay(new PasienEditDisplay(_mainDisplay, _listPasien[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }

        private void TabelPasien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayUtils.NomorUrut(TabelPasien);
        }
    }
}
