
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
            //PasienService pasien = new();

            MenuLanguage menu = LanguageConfig.getMenu;

            HeaderView.headerMenu();

            Console.WriteLine("========== Data Pasien ==========");

            //pasien.ShowAll();
            ViewSetup.userStatus.PrintCurrentState();
            ViewSetup.userStatus.ShowAvailableMenu();
            int pilihan = Convert.ToInt32(Console.ReadLine());
            while (!Defensive.SelectMenuOptionValidation(menu.patient_menu.Count, pilihan))
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
                    //pasien.Create();
                    break;
                case 2:
                    //pasien.Update();
                    break;
                case 3:
                    //pasien.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}

