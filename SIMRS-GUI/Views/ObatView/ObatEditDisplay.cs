using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.ObatView
{
    public partial class ObatEditDisplay : Form
    {
        private readonly ObatManager _obatManager;
        private readonly MainDisplay _mainDisplay;
        private Obat _obat;

        public ObatEditDisplay(MainDisplay mainDisplay, Obat obat)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _obatManager = new();
            _obat = obat;
        }

        private void ObatEditDisplay_Load(object sender, EventArgs e)
        {
            InputNama.Text = _obat.nama;
            InputHarga.Text = _obat.harga.ToString();
            if (_obat.jenis == Obat.EnumObat.PIL)
            {
                RadioPil.Select();
            }
            else if (_obat.jenis == Obat.EnumObat.SIRUP)
            {
                RadioSirup.Select();
            }
            else if (_obat.jenis == Obat.EnumObat.TABLET)
            {
                RadioTablet.Select();
            }
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
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

            await _obatManager.EditObat(new Obat(_obat.kode, nama, harga, jenis));
            _mainDisplay.ShowDisplay(new ObatDisplay(_mainDisplay));
        }
    }
}
