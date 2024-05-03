using System.Collections.Generic;
using SIMRS_API;
using SIMRS_CLI;
using SIMRS_CLI.ClientSideApi;
using SIMRS_CLI.Config;
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
        ReadWriteUtils<BankTransferConfig> ReadWriteBankTransfer =
            new ReadWriteUtils<BankTransferConfig>(
                DefaultConfig.BankTransferDefault(),
                "../../../Json/BankTransferConfig.json"
                );
        Console.WriteLine(ReadWriteBankTransfer.config.methods[3]);
    }
}