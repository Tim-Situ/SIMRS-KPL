namespace SIMRS_CLI.Models
{
    // Class Penampung Konfigurasi Menu
    public class MenuLanguage
    {
        public string title { get; set; }
        public List<string> main_menu { get; set; }
        public List<string> patient_menu { get; set; }
        public List<string> patient_add { get; set; }
        public string exit { get; set; }
        public string select { get; set; }

        public MenuLanguage(string title, List<string> main_menu, List<string> patient_menu, List<string> patient_add, string exit, string select)
        {
            this.title = title;
            this.main_menu = main_menu;
            this.patient_menu = patient_menu;
            this.patient_add = patient_add;
            this.exit = exit;
            this.select = select;
        }
    }

    public class Language
    {
        public string lang { get; set; }
        public MenuLanguage appEn { get; set; }
        public MenuLanguage appId { get; set; }

        public Language() { }

        public Language(string lang, MenuLanguage appEn, MenuLanguage appId)
        {
            this.lang = lang;
            this.appEn = appEn;
            this.appId = appId;
        }
    }
}

