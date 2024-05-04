using System;
using System.Security.Cryptography.Xml;
using SIMRS_CLI.Models;

namespace SIMRS_CLI.Config
{
    public static class DefaultConfig
    {
        public static BankTransfer BankTransferDefault()
        {
            Transfer tfData = new Transfer(250000000, 6500, 15000);
            Confirmation cfData = new Confirmation("yes", "ya");
            List<string> mtData = new List<string> { "RTO(real - time)", "SKN", "RTGS", "BI FAST" };
            return new BankTransfer("en", tfData, mtData, cfData);
        }

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
                "Exit",
                "Write option: ");
            return new Language("id", appEn, appId);
        }
    }
}


/*
EXAMPLE TO USE:

DefaultConfig.ValueDefault()

You can use this variabel on ReadWriteUtils argument.
*/
