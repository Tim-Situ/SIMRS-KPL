using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PemeriksaanView
{
    public partial class PemeriksaanEditDisplay : Form
    {
        private readonly PemeriksaanManager _pemeriksaanManager;
        private readonly PasienManager _pasienManager;
        private readonly DokterManager _dokterManager;
        private readonly ObatManager _obatManager;
        private readonly MainDisplay _mainDisplay;
        private Pemeriksaan _pemeriksaan;
        private List<Pasien> _listPasien { get; set; }
        private List<Dokter> _listDokter { get; set; }
        private List<Obat> _listObat { get; set; }
        Pasien pasien;
        Dokter dokter;
        Obat obat;
        public PemeriksaanEditDisplay(MainDisplay mainDisplay, Pemeriksaan pemeriksaan)
        {
            InitializeComponent();
            TopLevel = false;
            _pemeriksaanManager = new();
            _pasienManager = new();
            _dokterManager = new();
            _obatManager = new();
            _mainDisplay = mainDisplay;
            _pemeriksaan = pemeriksaan;
        }

        private async void PemeriksaanEditDisplay_Load(object sender, EventArgs e)
        {
            var responsePasien = await _pasienManager.GetPasien();
            _listPasien = responsePasien.data;
            var responseDokter = await _dokterManager.GetDokter();
            _listDokter = responseDokter.data;
            var responseObat = await _obatManager.GetObat();
            _listObat = responseObat.data;

            InputNIK.Text = _pemeriksaan.pasien.nik;
            InputNIP.Text = _pemeriksaan.dokter.nip;
            InputTanggal.Text = _pemeriksaan.tanggal;
            InputTinggiBadan.Text = _pemeriksaan.tinggiBadan.ToString();
            InputBeratBadan.Text = _pemeriksaan.beratBadan.ToString();
            InputTekananDarah.Text = _pemeriksaan.tekananDarah;
            InputKeluhan.Text = _pemeriksaan.keluhan;
            InputDiagnosa.Text = _pemeriksaan.diagnosa;
            InputKodeObat.Text = _pemeriksaan.obat.kode;
        }

        private void SearchNIK_Click(object sender, EventArgs e)
        {
            foreach (var item in _listPasien)
            {
                if (item.nik == InputNIK.Text)
                {
                    pasien = item;
                    OutputNamaPasien.Text = "Nama : " + item.nama;
                }
            }
            if (pasien == null)
            {
                MessageBox.Show("NIK pasien tidak ditemukan");
            }
        }

        private void SearchNIP_Click(object sender, EventArgs e)
        {
            foreach (var item in _listDokter)
            {
                if (item.nip == InputNIP.Text)
                {
                    dokter = item;
                    OutputNamaDokter.Text = "Nama : " + item.nama;
                }
            }
            if (dokter == null)
            {
                MessageBox.Show("NIP dokter tidak ditemukan");
            }
        }

        private void searchObat_Click(object sender, EventArgs e)
        {
            foreach (var item in _listObat)
            {
                if (item.kode == InputKodeObat.Text)
                {
                    obat = item;
                    OutputNamaObat.Text = "Nama : " + item.nama;
                }
            }
            if (obat == null)
            {
                MessageBox.Show("Kode obat tidak ditemukan");
            }
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {

            string tanggal = InputTanggal.Value.ToShortDateString();
            double tinggiBadan = double.Parse(InputTinggiBadan.Text);
            double beratBadan = double.Parse(InputBeratBadan.Text);
            string tekananDarah = InputTekananDarah.Text;
            string keluhan = InputKeluhan.Text;
            string diagnosa = InputDiagnosa.Text;

            if (pasien == null)
            {
                MessageBox.Show("Data pasien belum ada");
                return;
            }

            if (dokter == null)
            {
                MessageBox.Show("Data dokter belum ada");
                return;
            }

            if (tinggiBadan <= 0)
            {
                MessageBox.Show("Tinggi badan harus bernilai positif");
                return;
            }

            if (beratBadan <= 0)
            {
                MessageBox.Show("Berat badan harus bernilai positif");
                return;
            }

            if (InputValidator.ValidasiTekananDarah(tekananDarah))
            {
                MessageBox.Show("Nilai tekanan darah tidak valid");
                return;
            }

            if (keluhan.Length == 0)
            {
                MessageBox.Show("Keluhan tidak boleh kosong");
                return;
            }

            if (diagnosa.Length == 0)
            {
                MessageBox.Show("Diagnosa tidak boleh kosong");
                return;
            }

            if (obat == null)
            {
                MessageBox.Show("Data obat belum ada");
                return;
            }

            await _pemeriksaanManager.EditPemeriksaan(new Pemeriksaan(_pemeriksaan.kode, pasien, dokter, tanggal, tinggiBadan, beratBadan, tekananDarah, keluhan, diagnosa, obat));
            _mainDisplay.ShowDisplay(new PemeriksaanDisplay(_mainDisplay));

        }
    }
}
