using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PasienService : BaseService
    {
        ApiClient<Pasien> api = new();

        TableUtils tblPasien = new(new List<string>
                {
                    "No",
                    "NIK",
                    "Nama",
                    "Tanggal Lahir",
                    "No Hp",
                    "Jenis Kelamin",
                    "Alamat"
                });

        public override void ShowAll()
        {
            int no = 1;
            List<Pasien> dataPasien = api.ClientGetData("Pasien").GetAwaiter().GetResult().data;
            foreach (Pasien pasien in dataPasien)
            {
                tblPasien.addData(new List<string> { no.ToString(), pasien.nik, pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
                no++;
            }

            tblPasien.showData();
            tblPasien.clearData();
        }

        public override void ShowOne(string id)
        {
            Pasien pasien = api.ClientGetOneData($"Pasien/{id}").GetAwaiter().GetResult().data;
            tblPasien.addData(new List<string> { "1", pasien.nik, pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
            tblPasien.showData();
            tblPasien.clearData();
        }

        public override string Create()
        {
            Console.WriteLine("====== Tambah Data Pasien =======");
<<<<<<< HEAD

            Console.Write("Kode: ");
            string kode = Console.ReadLine();
=======
>>>>>>> 7a2ae5dfa56683dba383c464d269fb0b51176f36

            string NIK = PromptUser("NIK: ");
            string nama = PromptUser("Nama Pasien: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");
            User.EnumJenisKelamin jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);

<<<<<<< HEAD
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
=======
            string pesan = "Data pasien gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
>>>>>>> 7a2ae5dfa56683dba383c464d269fb0b51176f36
            {
                Pasien pasien = new Pasien(NIK, nama, tglLahir, noHp, jnsKelamin, alamat);
                pesan = api.ClientPostData(pasien, "Pasien").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Update()
        {

            string nik = PromptUser("\nMasukan NIK Pasien: ");
            ApiResponse<Pasien> respon = api.ClientGetOneData($"Pasien/{nik}").GetAwaiter().GetResult();
            if (!respon.success)
            {
                return respon.message;
            }
            Pasien pasien = respon.data;
            Console.Clear();
            ShowOne(nik);

            Console.WriteLine("Masukan data baru");
            string nama = PromptUser("Nama Pasien: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");

            pasien.nama = (nama == "") ? pasien.nama : nama;
            pasien.tglLahir = (tglLahir == "") ? pasien.tglLahir : tglLahir;
            pasien.noHp = (noHp == "") ? pasien.noHp : noHp;
            if (_jnsKelamin != "")
            {
                pasien.jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);
            }
            pasien.alamat = (alamat == "") ? pasien.alamat : alamat;

            string pesan = "Data pasien gagal diubah";
            if (Confirmation("Edit Data?"))
            {
                pesan = api.ClientPutData(pasien, $"Pasien/{nik}").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Delete()
        {
            string nik = PromptUser("\nMasukan NIK Pasien: ");
            string pesan = "Data pasien gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Pasien/{nik}").GetAwaiter().GetResult();
            }
            return pesan;
        }
    }
}
