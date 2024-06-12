using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PasienView
{
    public partial class PasienEditDisplay : Form
    {
        private readonly PasienManager _pasienManager;
        private readonly MainDisplay _mainDisplay;
        private Pasien _pasien;

        public PasienEditDisplay(MainDisplay mainDisplay, Pasien pasien)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pasienManager = new();
            _pasien = pasien;
        }

        private void PasienEditDisplay_Load(object sender, EventArgs e)
        {
            InputNama.Text = _pasien.nama;
            InputTanggal.Text = _pasien.tglLahir;
            InputNoHp.Text = _pasien.noHp;
            if (_pasien.jnsKelamin == User.EnumJenisKelamin.PRIA)
            {
                RadioPria.Select();
            }
            else
            {
                RadioWanita.Select();
            }
            InputAlamat.Text = _pasien.alamat;
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string nik = _pasien.nik;
            string nama = InputNama.Text;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = (RadioPria.Checked) ? User.EnumJenisKelamin.PRIA : User.EnumJenisKelamin.WANITA;
            string alamat = InputAlamat.Text;

            if (!InputValidator.ValidasiHurufSaja(nama))
            {
                MessageBox.Show("Nama hanya boleh terdiri dari huruf");
                return;
            }

            if (!InputValidator.ValidasiNoTelp(noHP))
            {
                MessageBox.Show("Nomor HP hanya boleh terdiri dari 10-13 digit angka");
                return;
            }

            if (alamat.Length == 0)
            {
                MessageBox.Show("Alamat harus ada isinya");
                return;
            }

            Pasien updatedPasien = new Pasien(nik, nama, tanggalLahir, noHP, jenisKelamin, alamat);
            await _pasienManager.EditPasien(updatedPasien);

            _mainDisplay.ShowDisplay(new PasienDisplay(_mainDisplay));
        }
    }
}
