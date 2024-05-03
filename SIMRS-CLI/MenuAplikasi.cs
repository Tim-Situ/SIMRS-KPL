using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;
using SIMRS_API;
using SIMRS_CLI.ClientSideApi;
using SIMRS_LIB;

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

        public async Task<List<Pasien>> callGetApi()
        {
            return await ApiClient<List<Pasien>>.ClientGetData("Pasien");
        }

        public void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine(
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

        public void MenuPasien()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine("======== Halaman Pasien =========");

                List<String> kolom = new List<string>
                {
                    "Nama",
                    "Tanggal Lahir",
                    "No Hp",
                    "Jenis Kelamin",
                    "Alamat"
                };

                TableUtils tblPasien = new TableUtils(kolom);
                List<Pasien> dataPasien = callGetApi().Result;
                foreach (Pasien pasien in dataPasien)
                {
                    tblPasien.addData(new List<string> { pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
                }

                tblPasien.showData();

                Console.WriteLine(
                    "[1] Tambah Data Pasien" +
                    "\n[2] Edit Data Pasien" +
                    "\n[3] Hapus Data Pasien" +
                    "\n[0] Kembali" +
                    "\n\nInputkan Pilihan Menu: "
                    );

                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        
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
