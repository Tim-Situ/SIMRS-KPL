using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PasienService : BaseService
    {
        ApiClient<Pasien> api = new();
        string pesan = "";

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

            Console.Write((dataPasien.Count == 0) ? "Data masih kosong!\n\n" : "");
        }

        public void ShowOne(string id)
        {
            Pasien pasien = api.ClientGetOneData($"Pasien/{id}").GetAwaiter().GetResult().data;
            tblPasien.addData(new List<string> { "1", pasien.nik, pasien.nama, pasien.tglLahir, pasien.noHp, pasien.jnsKelamin.ToString(), pasien.alamat });
            tblPasien.showData();
            tblPasien.clearData();
        }

        public override string Create()
        {
            Console.WriteLine("====== Tambah Data Pasien =======");

            string NIK = PromptUser("NIK: ");
            string nama = PromptUser("Nama Pasien: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");

            while (!Defensive.InputDateValidation(tglLahir))
            {
                tglLahir = PromptUser("Tanggal Lahir: ");
            };

            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");
            User.EnumJenisKelamin jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);

            pesan = "Data pasien gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                Pasien pasien = new Pasien(NIK, nama, tglLahir, noHp, jnsKelamin, alamat);
                pesan = api.ClientPostData(pasien, "Pasien").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public string Update()
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
            Console.WriteLine("(Langsung enter jika tidak ingin merubah data)");
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

            pesan = "Data pasien gagal diubah";
            if (Confirmation("Edit Data?"))
            {
                pesan = api.ClientPutData(pasien, $"Pasien/{nik}").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Delete()
        {
            string nik = PromptUser("\nMasukan NIK Pasien: ");
            pesan = "Data pasien gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Pasien/{nik}").GetAwaiter().GetResult();
            }
            return pesan;
        }
    }
}
