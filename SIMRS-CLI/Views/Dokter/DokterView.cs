using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS_CLI.ClientSideApi.Services;

namespace SIMRS_CLI.Views.Dokter
{
    public class DokterView
    {
        public static void DokterMenu()
        {
            DokterService dokter = new();

            HeaderView.headerMenu();

            Console.WriteLine("=========== Data Dokter ===========");

            dokter.ShowAll();

            ViewSetup.userStatus.ShowAvailableMenu();

            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    HeaderView.headerMenu();
                    dokter.Create();
                    break;
                case 2:
                    dokter.Update();
                    break;
                case 3:
                    dokter.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}
