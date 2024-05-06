using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PasienService
    {
        ApiClient<Pasien> api = new();

        TableUtils tblPasien = new(new List<string>
                {
                    "No",
                    "Nama",
                    "Tanggal Lahir",
                    "No Hp",
                    "Jenis Kelamin",
                    "Alamat"
                });

        public void ShowAll()
        {
            int no = 1;
            List<Pasien> dataPasien = api.ClientGetData("Pasien").GetAwaiter().GetResult();
            foreach (Pasien pasien in dataPasien)
            {
                tblPasien.addData(new List<string> { no.ToString(), pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
                no++;
            }

            tblPasien.showData();
            tblPasien.clearData();
        }

        public void ShowOne(string id)
        {
            Pasien pasien = api.ClientGetOneData($"Pasien/{id}").GetAwaiter().GetResult();
            tblPasien.addData(new List<string> { "1", pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
            tblPasien.showData();
            tblPasien.clearData();
        }

        public void Create()
        {
            Console.WriteLine("====== Tambah Data Pasien =======");

            Console.Write("Kode: ");
            string kode = Console.ReadLine();

            Console.Write("Nama Pasien: ");
            string nama = Console.ReadLine();

            Console.Write("Tanggal lahir: ");
            string tglLahir = Console.ReadLine();
            while (!DefensiveUtils.InputDateValidation(tglLahir))
            {
                Console.Write("Tanggal lahir: ");
                tglLahir = Console.ReadLine();
            };

            Console.Write("No HP: ");
            string noHp = Console.ReadLine();

            Console.Write("Jenis Kelamin (pria/wanita): ");
            string _jnsKelamin = Console.ReadLine();

            Console.Write("Alamat: ");
            string alamat = Console.ReadLine();

            User.EnumJenisKelamin jnsKelamin = User.EnumJenisKelamin.PRIA;
            if (_jnsKelamin.Equals("pria"))
            {
                jnsKelamin = User.EnumJenisKelamin.PRIA;
            }
            else if (_jnsKelamin.Equals("wanita"))
            {
                jnsKelamin = User.EnumJenisKelamin.WANITA;
            }

            Pasien pasien = new Pasien(kode, nama, tglLahir, noHp, jnsKelamin, alamat);
            api.ClientPostData(pasien, "Pasien").GetAwaiter().GetResult();
        }

        public void Update()
        {
            int idxPasien;
            Console.WriteLine("Pasien nomor berapa yang ingin diedit?");
            idxPasien = Convert.ToInt32(Console.ReadLine()) - 1;
            Pasien pasien = api.ClientGetOneData($"Pasien/{idxPasien}").GetAwaiter().GetResult();
            Console.Clear();
            ShowOne(idxPasien.ToString());

            Console.WriteLine("Masukan data baru");
            Console.Write("Nama Pasien: ");
            string nama = Console.ReadLine();

            Console.Write("Tanggal lahir: ");
            string tglLahir = Console.ReadLine();

            Console.Write("No HP: ");
            string noHp = Console.ReadLine();

            Console.Write("Jenis Kelamin (pria/wanita): ");
            string jnsKelamin = Console.ReadLine();

            Console.Write("Alamat: ");
            string alamat = Console.ReadLine();

            if (!nama.Equals(pasien.nama) && nama != "")
            {
                pasien.nama = nama;
            }
            if (!tglLahir.Equals(pasien.tglLahir) && tglLahir != "")
            {
                pasien.tglLahir = tglLahir;
            }
            if (!noHp.Equals(pasien.noHp) && noHp != "")
            {
                pasien.noHp = noHp;
            }

            if (jnsKelamin != "")
            {
                if (jnsKelamin.Equals("pria"))
                {
                    pasien.jnsKelamin = User.EnumJenisKelamin.PRIA;
                }
                else if (jnsKelamin.Equals("wanita"))
                {
                    pasien.jnsKelamin = User.EnumJenisKelamin.WANITA;
                }
            }

            if (!alamat.Equals(pasien.alamat) && alamat != "")
            {
                pasien.alamat = alamat;
            }

            api.ClientPutData(pasien, $"Pasien/{idxPasien}").GetAwaiter().GetResult();
        }

        public void Delete()
        {
            int idxPasien;
            Console.WriteLine("Pasien nomor berapa yang ingin dihapus?");
            idxPasien = Convert.ToInt32(Console.ReadLine()) - 1;
            var statusCode = api.ClientDeleteData($"Pasien/{idxPasien}").GetAwaiter().GetResult();
            Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");
        }



    }
}
