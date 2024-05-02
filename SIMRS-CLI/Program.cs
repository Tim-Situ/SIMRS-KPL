using SIMRS_CLI;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tes Implementasi Automata
        StatusPasien status_pasien = new StatusPasien();
        Console.WriteLine("Status Pasien : " + status_pasien.currentState);
        status_pasien.ActivateTrigger(Trigger.RESERVASI);
        status_pasien.ActivateTrigger(Trigger.PERIKSA_PASIEN);
        status_pasien.ActivateTrigger(Trigger.SELESAI_PEMERIKSAAN);
        status_pasien.ActivateTrigger(Trigger.AMBIL_OBAT);
        status_pasien.ActivateTrigger(Trigger.TRANSAKSI);
        status_pasien.ActivateTrigger(Trigger.SELESAI_TRANSAKSI);

        Hari hariIni = Hari.Senin;
        Console.WriteLine("Hari pemeriksaan: " + hariIni);
        Poli poli = Poli.ParuParu;
        Console.WriteLine("Poli yang dipilih: " + poli);
        JenisObat jenisObat = JenisObat.Pil;
        Console.WriteLine("Jenis obat: " + jenisObat);
    }
}