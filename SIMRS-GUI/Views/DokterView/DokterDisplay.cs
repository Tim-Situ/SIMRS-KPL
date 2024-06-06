using SIMRS_API;
using SIMRS_GUI.Services;
using SIMRS_GUI.Views.PasienView;

namespace SIMRS_GUI.Views.DokterView
{
    public partial class DokterDisplay : Form
    {
        private readonly DokterManager _dokterManager;
        private readonly MainDisplay _mainDisplay;
        private List<Dokter> _listDokter { get; set; }

        public DokterDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _dokterManager = new();
        }
        private void DokterDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Dokter>> response = await _dokterManager.GetDokter();
                _listDokter = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewDokter> gridViewDokter = _listDokter.Select(dokter =>
                {
                    return new GridViewDokter(
                        dokter.nip,
                        dokter.nama,
                        dokter.poli.namaPoli,
                        dokter.tglLahir,
                        dokter.noHp,
                        dokter.jnsKelamin.ToString(),
                        dokter.alamat
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewDokter.Count == 0)
                {
                    TabelDokter.Hide();
                    LabelDataKosong.Text = "Data dokter kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelDokter.InvokeRequired)
                    {
                        TabelDokter.Invoke(new Action(() => TabelDokter.DataSource = gridViewDokter));
                    }
                    else
                    {
                        TabelDokter.DataSource = gridViewDokter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewDokter
        {
            public string nip { get; set; }
            public string nama { get; set; }
            public string namaPoli { get; set; }
            public string tglLahir { get; set; }
            public string noHP { get; set; }
            public string jenisKelamin { get; set; }
            public string alamat { get; set; }

            public GridViewDokter(string nip, string nama, string namaPoli, string tglLahir, string noHP, string jenisKelamin, string alamat)
            {
                this.nip = nip;
                this.nama = nama;
                this.namaPoli = namaPoli;
                this.tglLahir = tglLahir;
                this.noHP = noHP;
                this.jenisKelamin = jenisKelamin;
                this.alamat = alamat;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new DokterTambahDisplay(_mainDisplay));
        }

        private async void TabelDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nipSelected;
            switch (TabelDokter.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    nipSelected = _listDokter[e.RowIndex].nip;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Dokter> response = await _dokterManager.DeleteDokter(nipSelected);
                        MessageBox.Show(response.message);
                    }
                    break;
                case "Edit":
                    _mainDisplay.ShowDisplay(new DokterEditDisplay(_mainDisplay, _listDokter[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }

        private void TabelDokter_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayUtils.NomorUrut(TabelDokter);
        }
    }
}
