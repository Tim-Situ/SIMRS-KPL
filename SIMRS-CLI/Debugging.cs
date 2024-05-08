using System;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;

namespace SIMRS_CLI
{
    public class Debugging
    {
        public static void DebugMenu()
        {
            MenuLanguage menu = LanguageConfig.getMenu;

            if (menu.main_menu.Count != 6)
            {
                Console.WriteLine("KESALAHAN: Jumlah main menu tidak sesuai -> " + menu.main_menu.Count);
            }
            else if (menu.patient_menu.Count != 3)
            {
                Console.WriteLine("KESALAHAN: Jumlah main menu tidak sesuai -> " + menu.main_menu.Count);
            }
            else if (menu.patient_add.Count != 6)
            {
                Console.WriteLine("KESALAHAN: Jumlah main menu tidak sesuai -> " + menu.main_menu.Count);
            }
            else
            {
                Console.WriteLine("Berhenti");
            }
            Console.WriteLine("Selesai");
        }
    }
}

