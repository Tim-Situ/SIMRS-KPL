using SIMRS_CLI;

internal class Program
{
    private static void Main(string[] args)
    {

        Hari hariIni = Hari.Senin;
        Console.WriteLine("Hari pemeriksaan: " + hariIni);
        Poli poli = Poli.ParuParu;
        Console.WriteLine("Poli yang dipilih: " + poli);
        JenisObat jenisObat = JenisObat.Pil;
        Console.WriteLine("Jenis obat: " + jenisObat);
    }
}