using SIMRS_API;

namespace SIMRS_GUI
{
    public partial class PasienEditDisplay : Form
    {
        private Pasien _pasien;
        public PasienEditDisplay(Pasien pasien)
        {
            _pasien = pasien;
            TopLevel = false;
            InitializeComponent();
        }

        private void PasienEditDisplay_Load(object sender, EventArgs e)
        {
            InputNama.Text = _pasien.nama;
            InputTanggal.Text = _pasien.tglLahir;
            InputNoHp.Text = _pasien.noHp;
            if (_pasien.jnsKelamin == User.EnumJenisKelamin.PRIA)
            {
                rbLakiLaki.Select();
            }
            else
            {
                rbPerempuan.Select();
            }
            InputAlamat.Text = _pasien.alamat;
        }
    }
}
