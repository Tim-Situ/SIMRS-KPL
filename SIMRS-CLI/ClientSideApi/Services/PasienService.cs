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
                tblPasien.addData(new List<string> { no.ToString(), pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
                no++;
            }

            tblPasien.showData();
            tblPasien.clearData();
        }

        public override void ShowOne(string id)
        {
            Pasien pasien = api.ClientGetOneData($"Pasien/{id}").GetAwaiter().GetResult().data;
            tblPasien.addData(new List<string> { "1", pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
            tblPasien.showData();
            tblPasien.clearData();
        }

        public override void Create()
        {
            Console.WriteLine("====== Tambah Data Pasien =======");
            
            string NIK = PromptUser("NIK: ");
            string nama = PromptUser("Nama Pasien: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToLower();
            string alamat = PromptUser("Alamat: ");
            User.EnumJenisKelamin jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);

            Pasien pasien = new Pasien(NIK, nama, tglLahir, noHp, jnsKelamin, alamat);
            api.ClientPostData(pasien, "Pasien").GetAwaiter().GetResult();
        }

        public override void Update()
        {
            int NIK;
            Console.WriteLine("Masukan NIK pasien yang ingin diedit!");
            NIK = Convert.ToInt32(Console.ReadLine());
            Pasien pasien = api.ClientGetOneData($"Pasien/{NIK}").GetAwaiter().GetResult().data;
            Console.Clear();
            ShowOne(NIK.ToString());

            Console.WriteLine("Masukan data baru");
            string nama = PromptUser("Nama Pasien: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToLower();
            string alamat = PromptUser("Alamat: ");
            User.EnumJenisKelamin jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);

            pasien.nama = nama ?? pasien.nama;
            pasien.tglLahir = tglLahir ?? pasien.tglLahir;
            pasien.noHp = noHp ?? pasien.noHp;

            if (_jnsKelamin != "")
            {
                pasien.jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);
            }

            pasien.alamat = alamat ?? pasien.alamat;

            Console.Clear();
            api.ClientPutData(pasien, $"Pasien/{NIK}").GetAwaiter().GetResult();
        }

        public override void Delete()
        {
            int NIK;
            Console.WriteLine("Masukan kode spesialis yang ingin dihapus!");
            NIK = Convert.ToInt32(Console.ReadLine()) - 1;
            Pasien pasien = api.ClientGetOneData($"Pasien/ {NIK}").GetAwaiter().GetResult().data;

            if (Confirmation($"Apakah anda yakin ingin menghapus spesialis dengan NIK {pasien.NIK}"))
            {
                var statusCode = api.ClientDeleteData($"Pasien/{NIK}").GetAwaiter().GetResult();
                Console.WriteLine($"Deleting... (HTTP Status = {(int)statusCode})");
            }
        }
    }
}
