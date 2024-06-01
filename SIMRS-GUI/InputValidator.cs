using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIMRS_GUI
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
