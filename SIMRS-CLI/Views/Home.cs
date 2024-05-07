using System;
using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_CLI.Views.Pasien;
using SIMRS_CLI.Views.Poli;
using SIMRS_LIB;

namespace SIMRS_CLI.Views
{
    public class Home
    {
        public static void MenuUtama()
        {
                HeaderView.headerMenu();

                MenuLanguage menu = LanguageConfig.getMenu;

                // UJI COBA MULTI ABHASA
                ViewSetup.userStatus.ShowAvailableMenu();
                int pilihan = Convert.ToInt32(Console.ReadLine());
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
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_PEMERIKSAAN);
                        break;
                    case 2:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_PEMBAYARAN);
                        break;
                    case 3:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_PASIEN);
                        break;
                    case 4:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_DOKTER);
                        break;
                    case 5:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_SPESIALIS);
                        PoliView.PoliMenu();
                        break;
                    case 6:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_OBAT);
                        break;

                    case 99:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.AKSES_MENU_GANTI_BAHASA);
                        break;

                    case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KELUAR);
                        break;
                };
        }
    }
}

