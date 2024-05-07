using System;
using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_CLI.Views.Pasien;
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
                        PasienView.PasienMenu();
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
    }
}

