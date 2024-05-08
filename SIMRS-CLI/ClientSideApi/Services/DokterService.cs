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
        ApiClient<Poli> apiPoli = new();
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
        public void ShowOne(string id)
        {
            Dokter dokter = api.ClientGetOneData($"Dokter/{id}").GetAwaiter().GetResult().data;
            tblDokter.addData(new List<string> { "1", dokter.nip, dokter.poli.namaPoli, dokter.nama, dokter.tglLahir, dokter.noHp, dokter.jnsKelamin.ToString(), dokter.alamat });
            tblDokter.showData();
            tblDokter.clearData();
        }

        public override string Create()
        {
            Console.WriteLine("====== Tambah Data Dokter =======");
            ApiResponse<List<Poli>> poliRespon;

            string NIP = PromptUser("NIP: ");

            do
            {
                string namaPoli = PromptUser("Poli: ");
                poliRespon = apiPoli.ClientGetData($"Poli?search={namaPoli}").GetAwaiter().GetResult();
                if (!poliRespon.success)
                {
                    Console.WriteLine("Nama poli tidak ditemukan");
                }
            } while (!poliRespon.success);
            Poli poli = poliRespon.data[0];

            string nama = PromptUser("Nama Dokter: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");

            while (!Defensive.InputDateValidation(tglLahir))
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
                Dokter dokter = new Dokter(NIP, nama, poli, tglLahir, noHp, jnsKelamin, alamat);
                pesan = api.ClientPostData(dokter, "Dokter").GetAwaiter().GetResult();
            }
            return pesan;
        }
        public string Update()
        {
            ApiResponse<List<Poli>> poliRespon;

            string nip = PromptUser("\nMasukan NIP Dokter: ");
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
            string namaPoli = PromptUser("Poli Dokter: ");
            if (namaPoli != "")
            {
                do
                {
                    poliRespon = apiPoli.ClientGetData($"Poli?search={namaPoli}").GetAwaiter().GetResult();
                    if (!poliRespon.success)
                    {
                        Console.WriteLine("Nama poli tidak ditemukan");
                        namaPoli = PromptUser("Poli: ");
                    }
                } while (!poliRespon.success);
                dokter.poli = poliRespon.data[0];
            }
            string nama = PromptUser("Nama Dokter: ");
            string tglLahir = PromptUser("Tanggal Lahir: ");
            string noHp = PromptUser("No HP: ");
            string _jnsKelamin = PromptUser("Jenis Kelamin (pria/wanita): ").ToUpper();
            string alamat = PromptUser("Alamat: ");

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
