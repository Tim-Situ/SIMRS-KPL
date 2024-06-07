using System.Text.RegularExpressions;

namespace SIMRS_GUI.Services
{
    public class InputValidator
    {
        public static bool ValidasiHurufSaja(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z\s]+$");
        }

        public static bool ValidasiNIK(string number)
        {
            return number.Length == 16 && Regex.IsMatch(number, @"^\d+$");
        }

        public static bool ValidasiNoTelp(string number)
        {
            return Regex.IsMatch(number, @"^\d{10,13}$");
        }
    }
}
