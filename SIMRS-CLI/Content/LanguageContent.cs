
using SIMRS_CLI.Models;

namespace SIMRS_CLI.Content
{
    public static class LanguageContent
    {
        public static Language LanguageDefault()
        {
            MenuLanguage appId = new MenuLanguage("========= Menu Aplikasi =========",
                new List<string>{
                  "Pemeriksaan",
                  "Pembayaran",
                  "Pasien",
                  "Dokter",
                  "Spesialis",
                  "Obat"
                },
                new List<string>{
                  "Tambah Data Pasien",
                  "Edit Data Pasien",
                  "Hapus Data Patient"
                },
                new List<string>{
                  "NIK Pasien",
                  "Nama Pasien",
                  "Tanggal Lahir",
                  "Nomor HP",
                  "Jenis Kelamin",
                  "Alamat"
                },
                "Keluar",
                "Ketik pilihan: ");
            MenuLanguage appEn =
                new MenuLanguage("======= Application Menu =======",
                new List<string>{
                  "Medical Check",
                  "Payment",
                  "Patient",
                  "Doctor",
                  "Specialist",
                  "Drug"
                },
                new List<string>{
                  "Add Patient Data",
                  "Edit Patient Data",
                  "Delete Patient Data"
                },
                new List<string>{
                  "Patient NIK",
                  "Patient Name",
                  "Birth Date",
                  "Phone Number",
                  "Sex",
                  "Address"
                },
                "Exit",
                "Write option: ");
            return new Language("id", appEn, appId);
        }
    }
}


/*
EXAMPLE TO USE:

DefaultContent.BankTransferDefault()

You can use this variabel on ReadWriteUtils argument.
*/
