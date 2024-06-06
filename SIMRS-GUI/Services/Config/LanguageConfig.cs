using SIMRS_LIB;

namespace SIMRS_GUI.Services.Config
{
    public static class LanguageConfig
    {
        public static Language defaultLang { get; set; }
        public static MenuLanguage getMenu { get; set; }
        public const string Filepath = @"../../../../SIMRS-GUI/Config/Json/LanguageConfig.json";

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


