
using SIMRS_CLI.ClientSideApi.Services;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_LIB;

namespace SIMRS_CLI.Views.Poli
{
    public class PoliView
    {
        public static void PoliMenu()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                PoliService poli = new();

                HeaderView.headerMenu();

                Console.WriteLine("=========== Data Poli ===========");

                poli.ShowAll();

                Console.Write(
                    "[1] Tambah Data Poli" +
                    "\n[2] Edit Data Poli" +
                    "\n[3] Hapus Data Poli" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        HeaderView.headerMenu();
                        poli.Create();
                        break;
                    case 2:
                        poli.Update();
                        break;
                    case 3:
                        poli.Delete();
                        break;
                };
                //Console.Clear();

            }
        }
    }
}

