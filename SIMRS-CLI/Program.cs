using SIMRS_CLI;
using SIMRS_CLI.Content;
using SIMRS_CLI.Models;
using SIMRS_LIB;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Menu menu = new Menu();
        menu.MenuUtama();

        // Tes Implementasi Automata
        //StatusPasien status_pasien = new StatusPasien();
        //Console.WriteLine("Status Pasien : " + status_pasien.currentState);
        //status_pasien.ActivateTrigger(Trigger.RESERVASI);
        //status_pasien.ActivateTrigger(Trigger.PERIKSA_PASIEN);
        //status_pasien.ActivateTrigger(Trigger.SELESAI_PEMERIKSAAN);
        //status_pasien.ActivateTrigger(Trigger.AMBIL_OBAT);
        //status_pasien.ActivateTrigger(Trigger.TRANSAKSI);
        //status_pasien.ActivateTrigger(Trigger.SELESAI_TRANSAKSI);

        // tes implementasi runtime
        ReadWriteUtils<BankTransfer> ReadWriteBankTransfer =
            new ReadWriteUtils<BankTransfer>(
                DefaultContent.BankTransferDefault(),
                "../../../Json/BankTransferConfig.json"
                );
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