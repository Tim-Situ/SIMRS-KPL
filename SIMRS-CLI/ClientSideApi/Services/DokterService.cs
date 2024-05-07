using SIMRS_API;
using SIMRS_LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class DokterService : BaseService
    {
        ApiClient<Dokter> api = new();
        string pesan = "";

        TableUtils tblDokter = new(new List<string>
        {
            "No",
            "NIP",
            "Poli",
            "Nama",
            "Tanggal Lahir",
            "Nomor Hp",
            "Jenis Kelamin",
            "Alamat"
        });
        public override void ShowAll()
        {
            int no = 1;
            List<Dokter> dataDokter = api.ClientGetData("Dokter").GetAwaiter().GetResult().data;
            foreach (Dokter dokter in dataDokter)
            {
                tblDokter.addData(new List<string> { no.ToString(), dokter.nip, dokter.poli.namaPoli, dokter.nama, dokter.tglLahir, dokter.noHp, dokter.jnsKelamin.ToString(), dokter.alamat });
                no++;
            }

            tblDokter.showData();
            tblDokter.clearData();

            Console.Write((dataDokter.Count == 0) ? "Data masih kosong!\n\n" : "");
        }
        public override void ShowOne(string id)
        {
            Dokter dokter = api.ClientGetOneData($"Dokter/{id}").GetAwaiter().GetResult().data;
            tblDokter.addData(new List<string> { "1", dokter.nip, dokter.poli.namaPoli, dokter.nama, dokter.tglLahir, dokter.noHp, dokter.jnsKelamin.ToString(), dokter.alamat });
            tblDokter.showData();
            tblDokter.clearData();
        }

        public override string Create()
        {
            Console.WriteLine("====== Tambah Data Dokter =======");

            string NIP = PromptUser("NIP: ");
            string poli = PromptUser("Poli: ");
            string nama = PromptUser("Nama Dokter: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");

            while (!DefensiveUtils.InputDateValidation(tglLahir))
            {
                tglLahir = PromptUser("Tanggal Lahir: ");
            };

            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");
            User.EnumJenisKelamin jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);

            pesan = "Data dokter gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                Dokter dokter = new Dokter(NIP, poli, nama, tglLahir, noHp, jnsKelamin, alamat);
                pesan = api.ClientPostData(dokter, "Dokter").GetAwaiter().GetResult();
            }
            return pesan;
        }
        public override string Update()
        {
            string nip  = PromptUser("\nMasukan NIP Dokter: ");
            ApiResponse<Dokter> respon = api.ClientGetOneData($"Dokter/{nip}").GetAwaiter().GetResult();
            if (!respon.success)
            {
                return respon.message;
            }
            Dokter dokter = respon.data;
            Console.Clear();
            ShowOne(nip);

            Console.WriteLine("Masukan data baru");
            Console.WriteLine("(Langsung enter jika tidak ingin merubah data)");
            string poli = PromptUser("Poli Dokter: ");
            string nama = PromptUser("Nama Dokter: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");

            dokter.poli = (poli == "") ? dokter.poli : poli;
            dokter.nama = (nama == "") ? dokter.nama : nama;
            dokter.tglLahir = (tglLahir == "") ? dokter.tglLahir : tglLahir;
            dokter.noHp = (noHp == "") ? dokter.noHp : noHp;
            if (_jnsKelamin != "")
            {
                dokter.jnsKelamin = Enum.Parse<User.EnumJenisKelamin>(_jnsKelamin);
            }
            dokter.alamat = (alamat == "") ? dokter.alamat : alamat;

            pesan = "Data dokter gagal diubah";
            if (Confirmation("Edit Data?"))
            {
                pesan = api.ClientPutData(dokter, $"Dokter/{nip}").GetAwaiter().GetResult();
            }
            return pesan;
        }
        public override string Delete()
        {
            string nip = PromptUser("\nMasukan NIP Dokter: ");
            pesan = "Data dokter gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Dokter/{nip}").GetAwaiter().GetResult();
            }
            return pesan;
        }

    }
}
