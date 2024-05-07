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
        public static StatusUser userStatus = new StatusUser();
        public static void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                HeaderView.headerMenu();

                MenuLanguage menu = LanguageConfig.getMenu;

                // UJI COBA MULTI ABHASA
                userStatus.ShowAvailableMenu();
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
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_PEMERIKSAAN);
                        Console.WriteLine(menu.main_menu[0]);
                        break;
                    case 2:
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_PEMBAYARAN);
                        Console.WriteLine(menu.main_menu[1]);
                        break;
                    case 3:
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_PASIEN);
                        PasienView.PasienMenu();
                        break;
                    case 4:
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_DOKTER);
                        Console.WriteLine(menu.main_menu[3]);
                        break;
                    case 5:
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_SPESIALIS);
                        PoliView.PoliMenu();
                        break;
                    case 6:
                        userStatus.ActivateTrigger(Trigger.AKSES_MENU_OBAT);
                        Console.WriteLine(menu.main_menu[5]);
                        break;

                    case 99:
                        LanguageConfig.ConfirmLanguage();
                        break;

                    case 0:
                        userStatus.ActivateTrigger(Trigger.KELUAR);
                        break;
                };
            }
        }
    }
}

