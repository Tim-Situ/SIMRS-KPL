using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.ObatView
{
    public partial class ObatTambahDisplay : Form
    {
        private readonly ObatManager _obatManager;
        private readonly MainDisplay _mainDisplay;

        public ObatTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _obatManager = new();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ApiResponse<List<Obat>> response = await _obatManager.GetObat();
            string kode = DisplayUtils.GenerateKode(response.data);

            string nama = InputNama.Text;
            int harga = int.Parse(InputHarga.Text);

            Obat.EnumObat jenis = default;
            if (RadioPil.Checked)
            {
                jenis = Obat.EnumObat.PIL;
            }
            else if (RadioSirup.Checked)
            {
                jenis = Obat.EnumObat.SIRUP;
            }
            else if (RadioTablet.Checked)
            {
                jenis = Obat.EnumObat.TABLET;
            }

            await _obatManager.AddObat(new Obat(kode, nama, harga, jenis));
            _mainDisplay.ShowDisplay(new ObatDisplay(_mainDisplay));
        }
    }
}
