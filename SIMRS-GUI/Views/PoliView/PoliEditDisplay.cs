using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PoliView
{
    public partial class PoliEditDisplay : Form
    {
        private readonly PoliManager _poliManager;
        private readonly MainDisplay _mainDisplay;
        private Poli _poli;

        public PoliEditDisplay(MainDisplay mainDisplay, Poli poli)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _poliManager = new();
            _poli = poli;
        }

        private void PoliditDisplay_Load(object sender, EventArgs e)
        {
            InputNama.Text = _poli.namaPoli;
            InputRuang.Text = _poli.ruang;
            InputBiaya.Text = _poli.biaya.ToString();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string nama = InputNama.Text;
            string ruang = InputRuang.Text;
            int biaya = int.Parse(InputBiaya.Text);

            if (!InputValidator.ValidasiHurufSaja(nama))
            {
                MessageBox.Show("Nama hanya boleh terdiri dari huruf");
                return;
            }

            if (ruang.Length == 0)
            {
                MessageBox.Show("Detail ruang tidak boleh kosong");
                return;
            }

            if (biaya <= 0)
            {
                MessageBox.Show("Biaya harus bernilai positif");
                return;
            }

            await _poliManager.EditPoli(new Poli(_poli.kode, nama, ruang, biaya));
            _mainDisplay.ShowDisplay(new PoliDisplay(_mainDisplay));
        }
    }
}
