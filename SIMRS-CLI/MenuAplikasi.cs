using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Models;
using SIMRS_CLI.Config;
using SIMRS_LIB;

namespace SIMRS_CLI
{
    internal class Menu
    {
        PasienService pasien = new();

        private async void headerMenu()
        {
            await Console.Out.WriteLineAsync(
                //"=================================\n" +
                //"=== Sistem Rekam Medis Pasien ===\n" +
                //"================================="
                );
        }

        public void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                LanguageConfig.initLanguage();

                MenuLanguage menu = LanguageConfig.getMenu;

                // UJI COBA MULTI ABHASA
                Console.WriteLine(menu.apptitle);
                for (int i = 0; i < menu.appmenu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu.appmenu[i]}");
                }
                Console.WriteLine($"[99] Ganti Bahasa");
                Console.WriteLine($"[0] {menu.appexit}");
                Console.WriteLine($"\n\n{menu.appselect}");
                pilihan = Convert.ToInt32(Console.ReadLine());
                while (!DefensiveUtils.SelectMenuOptionValidation(menu.appmenu.Count, pilihan))
                {
                    Console.WriteLine("tidak valid");
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                // END UJI COBA

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine(menu.appmenu[0]);
                        break;
                    case 2:
                        Console.WriteLine(menu.appmenu[1]);
                        break;
                    case 3:
                        MenuPasien();
                        break;
                    case 4:
                        Console.WriteLine(menu.appmenu[2]);
                        break;
                    case 5:
                        Console.WriteLine(menu.appmenu[3]);
                        break;
                    case 6:
                        Console.WriteLine(menu.appmenu[4]);
                        break;

                    case 99:
                        LanguageConfig.ConfirmLanguage();
                        break;

                    case 0:
                        break;
                };
            }
        }

        public void MenuPasien()
        {

            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine("========== Data Pasien ==========");

                pasien.ShowAll();

                Console.WriteLine(
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
                        pasien.Create();
                        break;
                    case 2:
                        pasien.Update();
                        break;
                    case 3:
                        pasien.Delete();
                        break;
                };
                Console.Clear();

            }
        }
    }
}
