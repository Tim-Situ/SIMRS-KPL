using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS_CLI.Config;
using SIMRS_CLI.Views.Dokter;
using SIMRS_CLI.Views.Obat;
using SIMRS_CLI.Views.Pasien;
using SIMRS_CLI.Views.Pembayaran;
using SIMRS_CLI.Views.Pemeriksaan;
using SIMRS_CLI.Views.Poli;

namespace SIMRS_CLI.Views
{
    public class ViewSetup
    {
        public static StatusUser userStatus = new StatusUser();

        public static void ViewController()
        {
            while (userStatus.currentStatus != Status.LOG_OUT)
            {
                switch (userStatus.currentStatus)
                {
                    case Status.HOME:
                        Home.MenuUtama();
                        break;
                    case Status.MENU_PEMERIKSAAN:
                        PemeriksaanView.PemeriksaanMenu();
                        break;
                    case Status.MENU_PEMBAYARAN: 
                        PembayaranView.PembayaranMenu();
                        break;
                    case Status.MENU_PASIEN:
                        PasienView.PasienMenu();
                        break;
                    case Status.MENU_DOKTER: 
                        DokterView.DokterMenu();
                        break;
                    case Status.MENU_SPESIALIS: 
                        PoliView.PoliMenu();
                        break;
                    case Status.MENU_OBAT: 
                        ObatView.ObatMenu();
                        break;
                    case Status.MENU_GANTI_BAHASA:
                        LanguageConfig.ConfirmLanguage();
                        break;
                    case Status.LOG_OUT:
                        userStatus.ActivateTrigger(Trigger.KELUAR);
                        break;
                }
            }
        }
    }
}
