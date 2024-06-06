using System.Text.RegularExpressions;

namespace SIMRS_GUI.Services
{
    public class InputValidator
    {
        public static bool ValidasiHurufSaja(string text)
        {
            return text != null && Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }

        public static bool ValidasiNIK(string number)
        {
            return number != null && number.Length == 16 && Regex.IsMatch(number, @"^\d+$");
        }

        public static bool ValidasiNoTelp(string number)
        {
            return number != null && Regex.IsMatch(number, @"^\d{10,13}$");
        }
    }
}
