using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.DokterView
{
    public partial class DokterTambahDisplay : Form
    {
        private readonly DokterManager _dokterManager;
        private readonly PoliManager _poliManager;
        private readonly MainDisplay _mainDisplay;
        private List<Poli> _listPoli { get; set; }

        public DokterTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _dokterManager = new();
            _poliManager = new();
        }

        private async void DokterTambahDisplay_Load(object sender, EventArgs e)
        {
            ApiResponse<List<Poli>> response = await _poliManager.GetPoli();
            _listPoli = response.data;
            if (_listPoli.Count > 0)
            {
                string[] opsiPoli = _listPoli.Select(poli => poli.namaPoli).ToArray();
                InputPoli.Items.AddRange(opsiPoli);
            }
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string NIP = InputNIP.Text;
            string nama = InputNama.Text;
            Poli poli = default;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = default;
            string alamat = InputAlamat.Text;


            if (!InputValidator.ValidasiNIP(NIP))
            {
                MessageBox.Show("NIP harus terdiri dari 18 digit angka");
                return;
            }

            if (!InputValidator.ValidasiHurufSaja(nama))
            {
                MessageBox.Show("Nama hanya boleh terdiri dari huruf");
                return;
            }

            if (InputPoli.Text == "(Pilih poli)")
            {
                MessageBox.Show("Pilih poli untuk dokter");
                return;
            }

            if (!InputValidator.ValidasiNoTelp(noHP))
            {
                MessageBox.Show("Nomor HP hanya boleh terdiri dari 10-13 digit angka");
                return;
            }

            if (!RadioPria.Checked && !RadioWanita.Checked)
            {
                MessageBox.Show("Jenis kelamin harus dipilih");
                return;
            }

            if (alamat.Length == 0)
            {
                MessageBox.Show("Alamat harus ada isinya");
                return;
            }
            
            jenisKelamin = (RadioPria.Checked)
                ? User.EnumJenisKelamin.PRIA
                : User.EnumJenisKelamin.WANITA;
            poli = _listPoli.Find(poli => poli.namaPoli == InputPoli.Text);
            await _dokterManager.AddDokter(new Dokter(NIP, nama, poli, tanggalLahir, noHP, jenisKelamin, alamat));
            _mainDisplay.ShowDisplay(new DokterDisplay(_mainDisplay));
        }
    }
}
