using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Components.Forms;
using SIMRS_API;
using SIMRS_CLI.ClientSideApi;
using SIMRS_CLI.Config;
using SIMRS_CLI.Models;
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
            // MODUL BAHASA MUNGKIN NANTI KU PISAH BIAR GAK PANJANG
            char langConfirm;
            MenuLanguage getMenu;
            Language defaultLang;

            ReadWriteUtils<Language> ReadWriteLanguage =
                new ReadWriteUtils<Language>(
                    DefaultConfig.LanguageDefault(),
                    "../../../Json/LanguageConfig.json"
                    );

            defaultLang = JsonUtils<Language>.ReadJsonFromFile("../../../Json/LanguageConfig.json");

            if (defaultLang.lang == "id")
            {
                Console.WriteLine("Selamat datang, bahasa saat ini: Indonesia");
                Console.Write("Ganti Bahasa? (y/n): ");
            }
            else
            {
                Console.WriteLine("Welcome, selected language: English");
                Console.Write("Change Language? (y/n): ");
            }
            langConfirm = Convert.ToChar(Console.ReadLine());

            if (langConfirm == 'y')
            {
                Console.WriteLine("yes ditakan: " + defaultLang.lang);
                if (defaultLang.lang == "id")
                {
                    defaultLang.lang = "en";
                    Console.WriteLine("id->en: " + defaultLang.lang);
                }
                else
                {
                    defaultLang.lang = "id";
                    Console.WriteLine("en->id: " + defaultLang.lang);
                }
                JsonUtils<Language>.WriteJsonFile(defaultLang, "../../../Json/LanguageConfig.json");
                defaultLang = JsonUtils<Language>.ReadJsonFromFile("../../../Json/LanguageConfig.json");
            }

            Console.WriteLine("bahasa sekarang" + defaultLang.lang);
            if (defaultLang.lang == "id")
            {
                getMenu = defaultLang.appId;
                Console.WriteLine(getMenu.apptitle);
            }
            else
            {
                getMenu = defaultLang.appEn;
                Console.WriteLine(getMenu.apptitle);
            }
            // END MODUL BAHASA

            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                // UJI COBA MULTI ABHASA
                Console.WriteLine(getMenu.apptitle);
                for (int i = 0; i < getMenu.appmenu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {getMenu.appmenu[i]}");
                }
                Console.WriteLine($"[0] {getMenu.appexit}");
                Console.WriteLine($"\n\n{getMenu.appselect}");

                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                // END UJI COBA

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
