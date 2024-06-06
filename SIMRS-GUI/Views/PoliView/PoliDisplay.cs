using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PoliView
{
    public partial class PoliDisplay : Form
    {
        private readonly PoliManager _poliManager;
        private readonly MainDisplay _mainDisplay;
        private List<Poli> _listPoli { get; set; }

        public PoliDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _poliManager = new();
        }

        private void PoliDisplay_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                // Get dari API.
                ApiResponse<List<Poli>> response = await _poliManager.GetPoli();
                _listPoli = response.data;

                // Ambil hanya nilai yang ingin ditampilkan
                // pada tabel.
                List<GridViewPoli> gridViewPoli = _listPoli.Select(poli =>
                {
                    return new GridViewPoli(
                        poli.namaPoli,
                        poli.ruang,
                        poli.biaya.ToString()
                        );

                }).ToList();

                // Cek apakah kosong atau tidak.
                if (gridViewPoli.Count == 0)
                {
                    TabelPoli.Hide();
                    LabelDataKosong.Text = "Data poli kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    // Jika tidak kosong, invoke agar tabel dapat
                    // menampilkan data terbaru dari async call.
                    if (TabelPoli.InvokeRequired)
                    {
                        TabelPoli.Invoke(new Action(() => TabelPoli.DataSource = gridViewPoli));
                    }
                    else
                    {
                        TabelPoli.DataSource = gridViewPoli;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
            }
        }

        private class GridViewPoli
        {
            public string nama { get; set; }
            public string ruang { get; set; }
            public string biaya { get; set; }

            public GridViewPoli(string nama, string ruang, string biaya)
            {
                this.nama = nama;
                this.ruang = ruang;
                this.biaya = biaya;
            }
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new PoliTambahDisplay(_mainDisplay));
        }

        private async void TabelPoli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode;
            switch (TabelPoli.Columns[e.ColumnIndex].Name)
            {
                case "Hapus":
                    kode = _listPoli[e.RowIndex].kode;
                    DialogResult dialogResult = MessageBox.Show(
                        "Apakah anda yakin untuk menghapus data ini?",
                        "Hapus data?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ApiResponse<Poli> response = await _poliManager.DeletePoli(kode);
                        MessageBox.Show(response.message);
                    }
                    break;
                case "Edit":
                    _mainDisplay.ShowDisplay(new PoliEditDisplay(_mainDisplay, _listPoli[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }

        private void TabelPoli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DisplayUtils.NomorUrut(TabelPoli);
        }
    }
}
