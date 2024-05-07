
using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_LIB;

namespace SIMRS_CLI.Views.Pasien
{
    public class PasienView
    {
        public static void PasienMenu()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                PasienService pasien = new();

                MenuLanguage menu = LanguageConfig.getMenu;

                HeaderView.headerMenu();

                Console.WriteLine("========== Data Pasien ==========");

                pasien.ShowAll();

                // UJI COBA MULTI ABHASA
                Console.WriteLine(menu.title);
                for (int i = 0; i < menu.patient_menu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu.patient_menu[i]}");
                }
                Console.WriteLine($"[0] {menu.exit}");
                Console.Write($"\n\n{menu.select}");
                pilihan = Convert.ToInt32(Console.ReadLine());
                while (!DefensiveUtils.SelectMenuOptionValidation(menu.patient_menu.Count, pilihan))
                {
                    Console.WriteLine("tidak valid");
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                // END UJI COBA

                //Console.WriteLine(
                //    "[1] Tambah Data Pasien" +
                //    "\n[2] Edit Data Pasien" +
                //    "\n[3] Hapus Data Pasien" +
                //    "\n[0] Kembali" +
                //    "\n\nInputkan Pilihan Menu: "
                //    );

                //pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        HeaderView.headerMenu();
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

