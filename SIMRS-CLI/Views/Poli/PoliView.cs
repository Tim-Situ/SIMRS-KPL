
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
                PoliService poli = new();

                HeaderView.headerMenu();

                Console.WriteLine("=========== Data Poli ===========");

                poli.ShowAll();

                ViewSetup.userStatus.ShowAvailableMenu();

                int pilihan = Convert.ToInt32(Console.ReadLine());

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
                    case 0:
                    ViewSetup.userStatus.ActivateTrigger(Trigger.KEMBALI);
                        break;
                };
                Console.Clear();
        }
    }
}

