﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS_CLI.Views.Pemeriksaan
{
    public class PemeriksaanView
    {
        public static void PemeriksaanMenu()
        {
            //PemeriksaanService pemeriksaan = new();

            HeaderView.headerMenu();

            Console.WriteLine("=========== Data Pemeriksaan ===========");

            //pemeriksaan.ShowAll();

            ViewSetup.userStatus.ShowAvailableMenu();

            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    HeaderView.headerMenu();
                    //pemeriksaan.Create();
                    break;
                case 2:
                    //pemeriksaan.Update();
                    break;
                case 3:
                    //pemeriksaan.Delete();
                    break;
                case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                    break;
            };
            Console.Clear();
        }
    }
}
