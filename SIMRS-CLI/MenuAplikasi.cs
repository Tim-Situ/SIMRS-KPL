using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;
using SIMRS_API;
using SIMRS_CLI.ClientSideApi;

namespace SIMRS_CLI
{
    internal class Menu
    {
        private async void headerMenu()
        {
            await Console.Out.WriteLineAsync(
                "=================================\n" +
                "=== Sistem Rekam Medis Pasien ===\n" +
                "================================="
                );
        }

        public async Task callGetApi()
        {
            List<Pasien> dataPasien = await ApiClient<List<Pasien>>.ClientGetData("Pasien");
            foreach (var item in dataPasien)
            {
                await Console.Out.WriteLineAsync(item.nama);
            }
        }

        public async void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                await Console.Out.WriteLineAsync(
                    "========= Menu Aplikasi =========" +
                    "\n[1] Pemeriksaan" +
                    "\n[2] Pembayaran" +
                    "\n[3] Pasien" +
                    "\n[4] Dokter" +
                    "\n[5] Spesialis" +
                    "\n[6] Obat" +
                    "\n[0] Exit" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Pemeriksaan");
                        break;
                    case 2:
                        Console.WriteLine("Pembayaran");
                        break;
                    case 3:
                        MenuPasien();
                        break;
                    case 4:
                        Console.WriteLine("Dokter");
                        break;
                    case 5:
                        Console.WriteLine("Spesialis");
                        break;
                    case 6:
                        Console.WriteLine("Obat");
                        break;

                    case 0:
                        Console.WriteLine("Anda akan keluar...");
                        if (Console.ReadLine() == "n")
                        {
                            pilihan = -1;
                        }
                        break;
                };
            }
        }

        public async void MenuPasien()
        {
           int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                await Console.Out.WriteLineAsync(
                    "======== Halaman Pasien =========" +
                    "\n[1] Data Pasein" +
                    "\n[2] Tambah Data Pasien" +
                    "\n[3] Edit Data Pasien" +
                    "\n[4] Hapus Data Pasien" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        var task = callGetApi();
                        task.Wait();
                        break;
                    case 2:
                        Console.WriteLine("Tambah Data Pasien");
                        break;
                    case 3:
                        Console.WriteLine("Edit Data Pasien");
                        break;
                    case 4:
                        Console.WriteLine("Hapus Data Pasien");
                        break;
                };
            }
        }
    }
}
