using System.Net;
using SIMRS_API;
using SIMRS_CLI.ClientSideApi;
using SIMRS_CLI.Models;
using SIMRS_CLI.Content;
using SIMRS_LIB;

namespace SIMRS_CLI
{
    internal class Menu
    {
        private async void headerMenu()
        {
            await Console.Out.WriteLineAsync(
                //"=================================\n" +
                //"=== Sistem Rekam Medis Pasien ===\n" +
                //"================================="
                );
        }

        public async Task<List<Pasien>> callGetApi(string path)
        {
            return await ApiClient<List<Pasien>>.ClientGetData(path);
        }
        public async Task callPostApi(Pasien data, string path)
        {
            await ApiClient<Pasien>.ClientPostData(data, path);
        }

        public async Task<HttpStatusCode> callDeleteApi(string path)
        {
            return await ApiClient<Pasien>.ClientDeleteData(path);
        }

        public void TabelPasien()
        {
            List<String> kolom = new List<string>
                {
                    "Nama",
                    "Tanggal Lahir",
                    "No Hp",
                    "Jenis Kelamin",
                    "Alamat"
                };

            TableUtils tblPasien = new TableUtils(kolom);
            List<Pasien> dataPasien = callGetApi("Pasien").Result;
            foreach (Pasien pasien in dataPasien)
            {
                tblPasien.addData(new List<string> { pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
            }

            tblPasien.showData();
        }

        public void MenuUtama()
        {
            int pilihan = -1;
            while (pilihan != 0)
            {
                headerMenu();

                LanguageContent.initLanguage();

                MenuLanguage menu = LanguageContent.getMenu;

                // UJI COBA MULTI ABHASA
                Console.WriteLine(menu.apptitle);
                for (int i = 0; i < menu.appmenu.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {menu.appmenu[i]}");
                }
                Console.WriteLine($"[88] Ganti Bahasa");
                Console.WriteLine($"[99] {menu.appexit}");
                Console.WriteLine($"\n\n{menu.appselect}");

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

                    case 88:
                        LanguageContent.ConfirmLanguage();
                        break;

                    case 99:
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
            int idxPasien = -1;
            while (pilihan != 0)
            {
                headerMenu();

                Console.WriteLine("======== Halaman Pasien =========");

                TabelPasien();

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
                        callPostApi(new Pasien("PSN003", "Nasi Goreng", "06-05-2024", "08", User.EnumJenisKelamin.PRIA, "Piring"), "Pasien").GetAwaiter().GetResult();
                        
                        break;
                    case 2:
                        Console.WriteLine("Pasien nomor berapa yang ingin diedit?");
                        break;
                    case 3:
                        Console.WriteLine("Pasien nomor berapa yang ingin dihapus?");
                        idxPasien = Convert.ToInt32(Console.ReadLine())-1;
                        var statusCode = callDeleteApi($"Pasien/{idxPasien}").GetAwaiter().GetResult();
                        Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");
                        break;
                };
            }
        }
    }
}
