namespace SIMRS_CLI.Models
{
    // Class Penampung Konfigurasi Menu
    public class MenuLanguage
    {
        public string apptitle { get; set; }
        public List<string> appmenu { get; set; }
        public string appexit { get; set; }
        public string appselect { get; set; }

        public MenuLanguage(string apptitle, List<string> appmenu, string appexit, string appselect)
        {
            this.apptitle = apptitle;
            this.appmenu = appmenu;
            this.appexit = appexit;
            this.appselect = appselect;
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

