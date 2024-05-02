using SIMRS_CLI;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // Tes implementasi API
        await ApiClient.RunAsync();

        // Tes Implementasi Automata
        StatusPasien status_pasien = new StatusPasien();
        Console.WriteLine("Status Pasien : " + status_pasien.currentState);
        status_pasien.ActivateTrigger(Trigger.RESERVASI);
        status_pasien.ActivateTrigger(Trigger.PERIKSA_PASIEN);
        status_pasien.ActivateTrigger(Trigger.SELESAI_PEMERIKSAAN);
        status_pasien.ActivateTrigger(Trigger.AMBIL_OBAT);
        status_pasien.ActivateTrigger(Trigger.TRANSAKSI);
        status_pasien.ActivateTrigger(Trigger.SELESAI_TRANSAKSI);

    }
}