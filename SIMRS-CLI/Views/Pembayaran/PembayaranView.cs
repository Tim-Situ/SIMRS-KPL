using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS_CLI.Views.Pembayaran
{
    internal class PembayaranView
    {
        public static void PembayaranMenu()
        {
            //PembayaranService pembayaran = new();

            HeaderView.headerMenu();

            Console.WriteLine("=========== Data Pembayaran ===========");

            //pembayaran.ShowAll();

            ViewSetup.userStatus.ShowAvailableMenu();

            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    HeaderView.headerMenu();
                    //pembayaran.Create();
                    break;
                case 2:
                    //pembayaran.Update();
                    break;
                case 3:
                    //pembayaran.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}
