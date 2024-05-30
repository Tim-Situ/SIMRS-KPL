using SIMRS_CLI.Content;
using SIMRS_CLI.Models;
using SIMRS_LIB;

namespace SIMRS_CLI.Config
{
    public static class LanguageConfig
    {
        public static Language defaultLang { get; set; }
        public static MenuLanguage getMenu { get; set; }
        public const string Filepath = @"../../../../SIMRS-CLI/Json/LanguageConfig.json";

        // method iniasiasi runtime configuration bahasa
        public static void InitLanguage()
        {
            // Memanggil class konfigurasi untuk membaca dan menulis bahasa
            ReadWriteUtils<Language> ReadWriteLanguage =
                new ReadWriteUtils<Language>(
                    LanguageContent.LanguageDefault(),
                    Filepath
                    );

            defaultLang = ReadWriteLanguage.config;
            SetMenuLanguage();
        }

        // method untuk mengeset bahasa
        public static void SetMenuLanguage()
        {
            if (defaultLang.lang == "id")
            {
                getMenu = defaultLang.appId;
            }
            else
            {
                getMenu = defaultLang.appEn;
            }
        }

        // method untuk konfirmasi ganti bahasa
        public static void ConfirmLanguage()
        {
            if (defaultLang.lang == "id")
            {
                Console.WriteLine("Selamat datang, bahasa saat ini: Indonesia");
                Console.Write("Ganti Bahasa? (y/n): ");
            }
            else
            {
                Console.WriteLine("Welcome, selected language: English");
                Console.Write("Change Language? (y/n): ");
            }
            char confirm = Convert.ToChar(Console.ReadLine());

            if (confirm == 'y')
            {
                ChangeLanguage();
            }
            Views.ViewSetup.userStatus.ActivateTrigger(Trigger.GANTI_BAHASA);
        }

        // method untuk mengganti bahasa
        public static void ChangeLanguage()
        {
            if (defaultLang.lang == "id")
            {
                defaultLang.lang = "en";
            }
            else
            {
                defaultLang.lang = "id";
            }

            JsonUtils<Language>.WriteJsonFile(defaultLang, Filepath);
            defaultLang = JsonUtils<Language>.ReadJsonFromFile(Filepath);

            SetMenuLanguage();
        }
    }
}

