using SIMRS_API;
using SIMRS_GUI.Services;
using SIMRS_GUI.Views.PasienView;

namespace SIMRS_GUI.Views.PembayaranView
{
    public partial class PembayaranTambahDisplay : Form
    {
        private readonly PembayaranManager _pembayaranManager;
        private readonly PemeriksaanManager _pemeriksaanManager;
        private readonly MainDisplay _mainDisplay;
        private List<Pemeriksaan> _pemeriksaanList { get; set; }
        Pemeriksaan pemeriksaan;
        private bool _bayaranValid = false;
        public PembayaranTambahDisplay(MainDisplay mainDisplay)
        {
            InitializeComponent();
            TopLevel = false;
            _pembayaranManager = new();
            _pemeriksaanManager = new();
            _mainDisplay = mainDisplay;
        }

        private async void PembayaranTambahDisplay_Load(object sender, EventArgs e)
        {
            ApiResponse<List<Pemeriksaan>> response = await _pemeriksaanManager.GetPemeriksaan();
            _pemeriksaanList = response.data;
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (_bayaranValid)
            {
                ApiResponse<List<Pembayaran>> response = await _pembayaranManager.GetPembayaran();
                string kode = DisplayUtils.GenerateKode(response.data);

                int uangBayar = int.Parse(InputUangPembayaran.Text);
                Pembayaran pembayaran = new Pembayaran(kode, pemeriksaan) { uangBayar = uangBayar};
                await _pembayaranManager.AddPembayaran(pembayaran);

                _mainDisplay.ShowDisplay(new PembayaranDisplay(_mainDisplay));
            }
            else
            {
                MessageBox.Show("Transaksi belum terbayar");
            }
        }

        private void SearchKodePembayaran_Click(object sender, EventArgs e)
        {
            foreach (var item in _pemeriksaanList)
            {
                if (item.kode == InputKodePemeriksaan.Text)
                {
                    pemeriksaan = item;
                    LabelNamaPasien.Text = "Nama Pasien :   " + item.pasien.nama;
                    LabelNamaDokter.Text = "Nama Dokter :   " + item.dokter.nama;
                    int total = item.dokter.poli.biaya + item.obat.harga;
                    LabelTotalTagihan.Text = "Total Tagihan :   " + total;
                }
            }
            if (pemeriksaan == null)
            {
                MessageBox.Show("Kode pemeriksaan tidak ditemukan");
            }
        }

        private void InputUangPembayaran_KeyUp(object sender, KeyEventArgs e)
        {
            LabelUangKembalian.Text = "Uang kembalian :   ";

            if (pemeriksaan == null)
            {
                LabelUangKembalian.Text += "Masukan kode pemeriksaan terlebih dahulu";
                _bayaranValid = false;
                return;
            }

            if (!InputValidator.ValidasiAngkaPositif(InputUangPembayaran.Text))
            {
                LabelUangKembalian.Text += "Input tidak valid, masukan angka";
                _bayaranValid = false;
                return;
            }

            int uangBayar = int.Parse(InputUangPembayaran.Text);
            int totalBiaya = pemeriksaan.dokter.poli.biaya + pemeriksaan.obat.harga;
            int kembalian = uangBayar - totalBiaya;

            if (kembalian >= 0)
            {
                LabelUangKembalian.Text += kembalian;
                _bayaranValid = true;
            }
            else
            {
                LabelUangKembalian.Text += "Uang bayar tidak cukup";
                _bayaranValid = false;
            }
        }
    }
}
