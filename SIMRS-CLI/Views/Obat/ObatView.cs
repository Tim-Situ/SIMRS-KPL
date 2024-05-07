using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMRS_CLI.ClientSideApi.Services;

namespace SIMRS_CLI.Views.Obat
{
    public class ObatView
    {
        public static void ObatMenu()
        {
            //ObatService obat = new();

            HeaderView.headerMenu();

            Console.WriteLine("=========== Data Obat ===========");

            //obat.ShowAll();

            ViewSetup.userStatus.ShowAvailableMenu();

            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    HeaderView.headerMenu();
                    //obat.Create();
                    break;
                case 2:
                    //obat.Update();
                    break;
                case 3:
                    //obat.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}
