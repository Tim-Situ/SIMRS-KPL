using SIMRS_API;

namespace SIMRS_GUI
{
    public partial class PasienTambahDisplay : Form
    {
        public PasienTambahDisplay()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void PasienTambahDisplay_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string NIK = InputNIK.Text;
            string nama = InputNama.Text;
            string tanggalLahir = InputTanggal.Text;
            string jenisKelamin = (rbLakiLaki.Checked) ? "PRIA" : "WANITA";
            string alamat = InputAlamat.Text;
        }
    }
}
