using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class PasienDisplay : Form
    {
        private List<Pasien> _listPasien { get; set; }
        private PasienManager _pasienManager;
        private MainDisplay _mainDisplay;

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
                ApiResponse<List<Pasien>> response = await _pasienManager.GetPasien();
                _listPasien = response.data;

                if (_listPasien.Count == 0)
                {
                    TabelPasien.Hide();
                    LabelDataKosong.Text = "Data pasien kosong";
                    LabelDataKosong.Show();
                }
                else
                {
                    if (TabelPasien.InvokeRequired)
                    {
                        TabelPasien.Invoke(new Action(() => TabelPasien.DataSource = _listPasien));
                    }
                    else
                    {
                        TabelPasien.DataSource = _listPasien;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil data: " + ex.Message);
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
                case "HapusPasien":
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
                case "EditPasien":
                    _mainDisplay.ShowDisplay(new PasienEditDisplay(_mainDisplay, _listPasien[e.RowIndex]));
                    break;
            }

            await LoadDataAsync();
        }
    }
}
