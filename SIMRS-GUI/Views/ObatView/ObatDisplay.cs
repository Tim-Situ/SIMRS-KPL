using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.ObatView
{
    public partial class ObatDisplay : Form
    {
        private readonly ObatManager _obatManager;
        private readonly MainDisplay _mainDisplay;
        private List<Obat> _listObat { get; set; }

        public ObatDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _obatManager = new();
        }

        private void ObatDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Obat>> response = await _obatManager.GetObat();
                _listObat = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewObat> gridViewObat = _listObat.Select(obat =>
                {
                    return new GridViewObat(
                        obat.kode,
                        obat.nama,
                        obat.harga.ToString(),
                        obat.jenis.ToString()
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewObat.Count == 0)
                {
                    TabelObat.Hide();
                    LabelDataKosong.Text = "Data obat kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelObat.InvokeRequired)
                    {
                        TabelObat.Invoke(new Action(() => TabelObat.DataSource = gridViewObat));
                    }
                    else
                    {
                        TabelObat.DataSource = gridViewObat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewObat
        {
            public string kode { get; set; }
            public string nama { get; set; }
            public string harga { get; set; }
            public string jenis { get; set; }

            public GridViewObat(string kode, string nama, string harga, string jenis)
            {
                this.kode = kode;
                this.nama = nama;
                this.harga = harga;
                this.jenis = jenis;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new ObatTambahDisplay(_mainDisplay));
        }

        private async void TabelObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode;
            switch (TabelObat.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    kode = _listObat[e.RowIndex].kode;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Obat> response = await _obatManager.DeleteObat(kode);
                        MessageBox.Show(response.message);
                    }
                    break;
                case "Edit":
                    _mainDisplay.ShowDisplay(new ObatEditDisplay(_mainDisplay, _listObat[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }

        private void TabelObat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayUtils.NomorUrut(TabelObat);
        }
    }
}
