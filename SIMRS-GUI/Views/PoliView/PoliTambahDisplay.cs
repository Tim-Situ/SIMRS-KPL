using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PoliView
{
    public partial class PoliTambahDisplay : Form
    {
        private readonly PoliManager _poliManager;
        private readonly MainDisplay _mainDisplay;

        public PoliTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _poliManager = new();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ApiResponse<List<Poli>> response = await _poliManager.GetPoli();
            string kode = DisplayUtils.GenerateKode(response.data);

            string nama = InputNama.Text;
            string ruang = InputRuang.Text;
            int biaya = int.Parse(InputBiaya.Text);

            await _poliManager.AddPoli(new Poli(kode, nama, ruang, biaya));
            _mainDisplay.ShowDisplay(new PoliDisplay(_mainDisplay));
        }
    }
}
