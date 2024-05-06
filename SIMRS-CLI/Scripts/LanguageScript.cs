﻿using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
using SIMRS_LIB;

namespace SIMRS_CLI.Scripts
{
    public static class LanguageScript
    {
        public static Language defaultLang { get; set; }
        public static MenuLanguage getMenu { get; set; }

        public static void initLanguage()
        {
            ReadWriteUtils<Language> ReadWriteLanguage =
                new ReadWriteUtils<Language>(
                    DefaultConfig.LanguageDefault(),
                    "../../../Json/LanguageConfig.json"
                    );

            defaultLang = JsonUtils<Language>.ReadJsonFromFile("../../../Json/LanguageConfig.json");
            setMenuLanguage();
        }

        public static void setMenuLanguage()
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
        }

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

            JsonUtils<Language>.WriteJsonFile(defaultLang, "../../../Json/LanguageConfig.json");
            defaultLang = JsonUtils<Language>.ReadJsonFromFile("../../../Json/LanguageConfig.json");

            setMenuLanguage();
        }
    }
}

