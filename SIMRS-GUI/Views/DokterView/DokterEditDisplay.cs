using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.DokterView
{
    public partial class DokterEditDisplay : Form
    {
        private readonly DokterManager _dokterManager;
        private readonly PoliManager _poliManager;
        private readonly MainDisplay _mainDisplay;
        private List<Poli> _listPoli { get; set; }
        private Dokter _dokter;

        public DokterEditDisplay(MainDisplay mainDisplay, Dokter dokter)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _dokterManager = new();
            _poliManager = new();
            _dokter = dokter;
        }

        private async void DokterEditDisplay_Load(object sender, EventArgs e)
        {
            ApiResponse<List<Poli>> response = await _poliManager.GetPoli();
            _listPoli = response.data;
            if (_listPoli.Count > 0)
            {
                string[] opsiPoli = _listPoli.Select(poli => poli.namaPoli).ToArray();
                InputPoli.Items.AddRange(opsiPoli);
            }

            InputNama.Text = _dokter.nama;
            InputPoli.Text = _dokter.poli.namaPoli;
            InputTanggal.Text = _dokter.tglLahir;
            InputNoHp.Text = _dokter.noHp;
            if (_dokter.jnsKelamin == User.EnumJenisKelamin.PRIA)
            {
                RadioPria.Select();
            }
            else
            {
                RadioWanita.Select();
            }
            InputAlamat.Text = _dokter.alamat;
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string nama = InputNama.Text;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();
            Poli poli = default;
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = default;
            string alamat = InputAlamat.Text;

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
            await _dokterManager.EditDokter(new Dokter(_dokter.nip, nama, poli, tanggalLahir, noHP, jenisKelamin, alamat));
            _mainDisplay.ShowDisplay(new DokterDisplay(_mainDisplay));

        }
    }
}
