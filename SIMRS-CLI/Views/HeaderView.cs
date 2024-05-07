using System;
namespace SIMRS_CLI.Views
{
    public class HeaderView
    {
        public static async void headerMenu()
        {
            await Console.Out.WriteLineAsync(
                "=================================\n" +
                "=== Sistem Rekam Medis Pasien ===\n" +
                "================================="
                );
        }
    }
}

