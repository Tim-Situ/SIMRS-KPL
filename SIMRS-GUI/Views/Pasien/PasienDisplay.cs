using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class PasienDisplay : Form
    {
        private PasienManager pasienManager = new();
        private List<Pasien> listPasien { get; set; }
        private MainDisplay _mainDisplay;
        public PasienDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            LoadDataAsync();
            _mainDisplay = mainDisplay;
        }

        private async Task LoadDataAsync()
        {
            try
            {
                ApiResponse<List<Pasien>> response = await pasienManager.GetPasien();
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

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void ButtonTambah_Click(object sender, EventArgs e)
        {
            _mainDisplay.ShowDisplay(new PasienTambahDisplay());
        }

        private void TabelPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (TabelPasien.Columns[e.ColumnIndex].Name)
            {
                case "HapusPasien":
                    MessageBox.Show("Hapus " + listPasien[e.RowIndex].nik);
                    break;
                case "EditPasien":
                    _mainDisplay.ShowDisplay(new PasienEditDisplay(listPasien[e.RowIndex]));
                    break;
            }
        }
    }
}
