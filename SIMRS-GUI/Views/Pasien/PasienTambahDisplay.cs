using SIMRS_API;
using SIMRS_GUI.Services;

namespace SIMRS_GUI
{
    public partial class PasienTambahDisplay : Form
    {
        private PasienManager _pasienManager;
        private MainDisplay _mainDisplay;

        public PasienTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _mainDisplay = mainDisplay;
            _pasienManager = new();

        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string NIK = InputNIK.Text;
            string nama = InputNama.Text;
            string tanggalLahir = InputTanggal.Value.ToShortDateString();
            string noHP = InputNoHp.Text;
            User.EnumJenisKelamin jenisKelamin = (RadioPria.Checked) 
                ? User.EnumJenisKelamin.PRIA 
                : User.EnumJenisKelamin.WANITA;
            string alamat = InputAlamat.Text;

            await _pasienManager.AddPasien(new Pasien(NIK, nama, tanggalLahir, noHP, jenisKelamin, alamat));
            _mainDisplay.ShowDisplay(new PasienDisplay(_mainDisplay));
        }
    }
}
