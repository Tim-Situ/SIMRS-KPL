using SIMRS_CLI;
using SIMRS_CLI.Config;
using SIMRS_CLI.Content;
using SIMRS_CLI.Models;
using SIMRS_CLI.Views;
using SIMRS_LIB;

internal class Program
{
    private static async Task Main(string[] args)
    {
        LanguageConfig.initLanguage();
        //menu.MenuUtama();.
        ViewSetup.ViewController();

        // Tes Implementasi Automata
        //StatusPasien status_pasien = new StatusPasien();
        //Console.WriteLine("Status Pasien : " + status_pasien.currentState);
        //status_pasien.ActivateTrigger(Trigger.RESERVASI);
        //status_pasien.ActivateTrigger(Trigger.PERIKSA_PASIEN);
        //status_pasien.ActivateTrigger(Trigger.SELESAI_PEMERIKSAAN);
        //status_pasien.ActivateTrigger(Trigger.AMBIL_OBAT);
        //status_pasien.ActivateTrigger(Trigger.TRANSAKSI);
        //status_pasien.ActivateTrigger(Trigger.SELESAI_TRANSAKSI);

        //Console.WriteLine(ReadWriteBankTransfer.config.methods[3]);

        //BankTransfer data = DefaultConfig.BankTransferDefault();
        //JsonUtils<BankTransfer>.WriteJsonFile(data, "../../../Json/tesperubahan.json");
        //BankTransfer sebelum = JsonUtils<BankTransfer>.ReadJsonFromFile("../../../Json/tesperubahan.json");
        //Console.WriteLine(sebelum.lang);
        //data.lang = "id";
        //JsonUtils<BankTransfer>.WriteJsonFile(data, "../../../Json/tesperubahan.json");
        //BankTransfer sesudah = JsonUtils<BankTransfer>.ReadJsonFromFile("../../../Json/tesperubahan.json");
        //Console.WriteLine(sesudah.lang);
        //data.lang = "ar";
        //JsonUtils<BankTransfer>.WriteJsonFile(data, "../../../Json/tesperubahan.json");
        //BankTransfer akhir = JsonUtils<BankTransfer>.ReadJsonFromFile("../../../Json/tesperubahan.json");
        //Console.WriteLine(akhir.lang);

    }
}