﻿using SIMRS_CLI.ClientSideApi.Services;

namespace SIMRS_CLI.Views.Pembayaran
{
    internal class PembayaranView
    {
        public static void PembayaranMenu()
        {
            PembayaranService pembayaran = new();

            HeaderView.HeaderMenu();

            Console.WriteLine("=========== Data Pembayaran ===========");

            pembayaran.ShowAll();

            ViewSetup.userStatus.ShowAvailableMenu();

            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    HeaderView.HeaderMenu();
                    pembayaran.Create();
                    break;
                case 2:
                    pembayaran.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}
