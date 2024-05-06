using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace SIMRS_LIB
{
    public class MenuUtils<T>
    {
        public static bool InputDateValidation(string date)
        {
            // memecah string sesuai format dd-mm-yyyy
            string[] dateSplitted = date.Split("-");

            // mengambil hasil split date dan mengkonversi ke integer
            int dd = int.Parse(dateSplitted[0]);
            int mm = int.Parse(dateSplitted[1]);
            int yyyy = int.Parse(dateSplitted[2]);

            // memastikan bulan kabisat atau bukan untuk menentukan tanggal di bulan februari
            bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            // mengecek batas tanggal berdasarkan bulan
            int[] daysInMonth = { 31, IsLeapYear(yyyy) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // validasi tahun (DBC: 1950-2100)
            bool IsValidYear = yyyy >= 1950 && yyyy < 2100;

            // validasi tanggal
            // PREKONDISI:
            // 1. Memastikan tanggal valid
            Debug.Assert(dd < 1 || dd > daysInMonth[mm - 1]);
            // 2. memastikan bulan valid
            Debug.Assert(mm < 1 || mm > 12);
            // 3. memastikan tahun valid
            Debug.Assert(!IsValidYear);

            // EXCEPTION: 
            bool result = (mm < 1 || mm > 12 || !IsValidYear) && (dd < 1 || dd > daysInMonth[mm - 1]);

            // POST CONDITION:
            return result;
        }

        public static bool SelectMenuOptionValidation(int countMenu, string input)
        {
            // validasi input opsi
            int parsedInput;

            // PREKONDISI:
            // 1. Memastikan input bisa di convert ke integer
            Debug.Assert(int.TryParse(input, out parsedInput));
            // 2. Memastikan angka input tidak lebih dari jumlah menu (kecuali 99 untuk ganti bahasa, 0 untuk exit)
            Debug.Assert(parsedInput < 1 || (parsedInput > countMenu && (parsedInput != 99 || parsedInput != 0)));

            // EXCEPTION: 
            bool result = parsedInput < 1 || (parsedInput > countMenu && (parsedInput != 99 || parsedInput != 0));

            // POST CONDITION:
            return result;
        }
    }
}

