using System.Diagnostics;

namespace SIMRS_LIB
{
    public class DefensiveUtils
    {
        public static bool InputDateValidation(string date)
        {

            // memecah string sesuai format dd-mm-yyyy
            string[] dateSplitted = date.Split("-");

            // PREKONDISI:
            // validasi format
            // 1. Memastikan tanggal valid
            Debug.Assert(int.TryParse(dateSplitted[0], out _), "KESALAHAN FORMAT INPUT: Gagal mengambil tanggal.");
            // 2. memastikan bulan valid
            Debug.Assert(int.TryParse(dateSplitted[1], out _), "KESALAHAN FORMAT INPUT: Gagal mengambil bulan.");
            // 3. memastikan tahun valid
            Debug.Assert(int.TryParse(dateSplitted[2], out _), "KESALAHAN FORMAT INPUT: Gagal mengambil tahun.");

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

            // PREKONDISI:
            // validasi tanggal
            // 4. memastikan tahun valid
            Debug.Assert(IsValidYear, "KESALAHAN INPUT: Tahun tidak valid.");
            // 6. memastikan bulan valid
            Debug.Assert(mm >= 1 && mm <= 12, "KESALAHAN INPUT: Bulan tidak valid.");
            // 7. Memastikan tanggal valid
            Debug.Assert(dd >= 1 && dd <= daysInMonth[mm - 1], "KESALAHAN INPUT: Tanggal tidak valid.");

            // EXCEPTION: 
            bool result = (mm >= 1 && mm <= 12 && IsValidYear) && (dd >= 1 || dd <= daysInMonth[mm - 1]);

            // POST CONDITION:
            return result;
        }

        public static bool SelectMenuOptionValidation(int countMenu, int input)
        {
            // validasi input opsi
            // PREKONDISI:
            // 1. Memastikan angka input tidak lebih dari jumlah menu (kecuali 99 untuk ganti bahasa, 0 untuk exit)
            Debug.Assert((input >= 1 && input <= countMenu) || input == 99 || input == 0, $"KESALAHAN INPUT: Pilihan menu tersedia hanya 1-{countMenu}, 99 untuk ganti bahasa, dan 0 untuk keluar.");

            // EXCEPTION: 
            bool result = (input >= 1 && input <= countMenu) || input == 99 || input == 0;

            // POST CONDITION:
            return result;
        }
    }
}

