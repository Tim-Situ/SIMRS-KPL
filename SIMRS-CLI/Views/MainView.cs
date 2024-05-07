using System;
using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_CLI.Views.Pasien;
using SIMRS_CLI.Views.Poli;
using SIMRS_LIB;

namespace SIMRS_CLI.Views
{
    public class MainView
    {
        public static void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                HeaderView.headerMenu();

                MenuLanguage menu = LanguageConfig.getMenu;

                // UJI COBA MULTI ABHASA
                Console.WriteLine(menu.title);
                for (int i = 0; i < menu.main_menu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu.main_menu[i]}");
                }
                Console.WriteLine($"[99] Ganti Bahasa");
                Console.WriteLine($"[0] {menu.exit}");
                Console.WriteLine($"\n\n{menu.select}");
                pilihan = Convert.ToInt32(Console.ReadLine());
                while (!DefensiveUtils.SelectMenuOptionValidation(menu.main_menu.Count, pilihan))
                {
                    Console.WriteLine("tidak valid");
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
                // END UJI COBA

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine(menu.main_menu[0]);
                        break;
                    case 2:
                        Console.WriteLine(menu.main_menu[1]);
                        break;
                    case 3:
                        PasienView.PasienMenu();
                        break;
                    case 4:
                        Console.WriteLine(menu.main_menu[3]);
                        break;
                    case 5:
                        PoliView.PoliMenu();
                        break;
                    case 6:
                        Console.WriteLine(menu.main_menu[5]);
                        break;

                    case 99:
                        LanguageConfig.ConfirmLanguage();
                        break;

                    case 0:
                        break;
                };
            }
        }
    }
}

