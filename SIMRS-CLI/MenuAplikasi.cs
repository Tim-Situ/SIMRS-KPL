using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Models;
using SIMRS_CLI.Content;
using SIMRS_LIB;

namespace SIMRS_CLI
{
    internal class Menu
    {
        static string pesan = "";
        PasienService pasien = new();
        PoliService poli = new();

        private async void headerMenu()
        {
            await Console.Out.WriteLineAsync(
                "=================================\n" +
                "=== Sistem Rekam Medis Pasien ===\n" +
                "================================="
                );
        }        

        public void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                LanguageContent.initLanguage();

                MenuLanguage menu = LanguageContent.getMenu;

                // UJI COBA MULTI ABHASA
                Console.WriteLine(menu.apptitle);
                for (int i = 0; i < menu.appmenu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu.appmenu[i]}");
                }
                Console.WriteLine($"[88] Ganti Bahasa");
                Console.WriteLine($"[0] {menu.appexit}");
                Console.WriteLine($"\n\n{menu.appselect}");

                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // END UJI COBA

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Pemeriksaan");
                        break;
                    case 2:
                        Console.WriteLine("Pembayaran");
                        break;
                    case 3:
                        MenuPasien();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Dokter");
                        break;
                    case 5:
                        MenuPoli();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Obat");
                        break;

                    case 88:
                        LanguageContent.ConfirmLanguage();
                        break;

                    case 0:
                        break;
                };
            }
        }

        public void MenuPoli()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine("=========== Data Poli ===========");

                poli.ShowAll();

                Console.Write(
                    "[1] Tambah Data Poli" +
                    "\n[2] Edit Data Poli" +
                    "\n[3] Hapus Data Poli" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        headerMenu();
                        poli.Create();
                        break;
                    case 2:
                        poli.Update();
                        break;
                    case 3:
                        poli.Delete();
                        break;
                };
                Console.Clear();
            }
        }

        public void MenuPasien()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine("========== Data Pasien ==========");
                if (pesan != "")
                {
                    Console.WriteLine("\n" + pesan);
                    pesan = "";
                }
                pasien.ShowAll();

                Console.Write(
                    "[1] Tambah Data Pasien" +
                    "\n[2] Edit Data Pasien" +
                    "\n[3] Hapus Data Pasien" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        headerMenu();
                        pesan = pasien.Create();
                        Console.Clear();
                        break;
                    case 2:
                        pesan = pasien.Update();
                        break;
                    case 3:
                        pesan = pasien.Delete();
                        break;
                };
            }
        }
    }
}
