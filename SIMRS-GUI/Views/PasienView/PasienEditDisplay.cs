using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI.Views.PasienView
{
    public partial class PasienEditDisplay : Form
    {
        private PasienManager _pasienManager;
        private MainDisplay _mainDisplay;
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
            string nama = InputNama.Text;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = (RadioPria.Checked)
                ? User.EnumJenisKelamin.PRIA
                : User.EnumJenisKelamin.WANITA;
            string alamat = InputAlamat.Text;

            await _pasienManager.EditPasien(new Pasien(_pasien.nik, nama, tanggalLahir, noHP, jenisKelamin, alamat));
            _mainDisplay.ShowDisplay(new PasienDisplay(_mainDisplay));
        }
    }
}
