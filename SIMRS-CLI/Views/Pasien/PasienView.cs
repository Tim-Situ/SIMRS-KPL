
using SIMRS_CLI.ClientSideApi.Services;

namespace SIMRS_CLI.Views.Pasien
{
    public class PasienView
    {
        public static void PasienMenu()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                PasienService pasien = new();

                HeaderView.headerMenu();

                Console.WriteLine("========== Data Pasien ==========");

                pasien.ShowAll();

                Console.WriteLine(
                    "[1] Tambah Data Pasien" +
                    "\n[2] Edit Data Pasien" +
                    "\n[3] Hapus Data Pasien" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        HeaderView.headerMenu();
                        pasien.Create();
                        break;
                    case 2:
                        pasien.Update();
                        break;
                    case 3:
                        pasien.Delete();
                        break;
                };
                Console.Clear();

            }
        }
    }
}

