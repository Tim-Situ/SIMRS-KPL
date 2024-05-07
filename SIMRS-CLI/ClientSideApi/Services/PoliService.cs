﻿using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PoliService : BaseService
    {
        ApiClient<Poli> api = new();
        string pesan = "";

        TableUtils tblPoli = new(new List<string>
        {
            "No",
            "Kode Poli",
            "Nama Poli",
            "Ruang",
            "Biaya"
        });

        public override void ShowAll()
        {
            int no = 1;
            List<Poli> dataPoli = api.ClientGetData("Poli").GetAwaiter().GetResult().data;
            foreach (Poli Poli in dataPoli)
            {
                tblPoli.addData(new List<string> { no.ToString(), Poli.kode, Poli.namaPoli, Poli.ruang, Poli.biaya.ToString() });
                no++;
            }

            tblPoli.showData();
            tblPoli.clearData();
        }

        public override void ShowOne(string id)
        {
            Poli Poli = api.ClientGetOneData($"Poli/{id}").GetAwaiter().GetResult().data;
            tblPoli.addData(new List<string> { "1", Poli.kode, Poli.namaPoli, Poli.ruang, Poli.biaya.ToString() });
            tblPoli.showData();
            tblPoli.clearData();
        }

        public override string Create()
        {
            Console.WriteLine("======= Tambah Data Poli ========");

            string kode = PromptUser("Kode: ");
            string namaPoli = PromptUser("Nama Poli: ");
            string ruang = PromptUser("Ruang: ");
            int biaya = Convert.ToInt32(PromptUser("Biaya: "));

            pesan = "Data spesialis gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                Poli Poli = new Poli(kode, namaPoli, ruang, biaya);
                pesan = api.ClientPostData(Poli, "Poli").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Update()
        {
            string kodePoli = PromptUser("Masukan kode spesialis: ");
            ApiResponse<Poli> respon = api.ClientGetOneData($"Poli/{kodePoli}").GetAwaiter().GetResult();
            if (!respon.success)
            {
                return respon.message;
            }
            Poli poli = respon.data;
            Console.Clear();
            ShowOne(kodePoli);

            Console.WriteLine("Masukan data baru");
            string namaPoli = PromptUser("Nama Poli: ");
            string ruang = PromptUser("Ruang: ");
            int biaya = Convert.ToInt32(PromptUser("Biaya: "));

            poli.namaPoli = (namaPoli == "") ? poli.namaPoli : namaPoli;
            poli.ruang = (ruang == "") ? poli.ruang : ruang;
            poli.biaya = (biaya == 0) ? poli.biaya : biaya;

            pesan = "Data poli gagal diubah";
            if (Confirmation("Edit Data?"))
            {
                pesan = api.ClientPutData(poli, $"Poli/{kodePoli}").GetAwaiter().GetResult();
            }
            return pesan;

        }

        public override string Delete()
        {
            string kodePoli = PromptUser("Masukan kode spesialis: ");
            pesan = "Data poli gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Poli/{kodePoli}").GetAwaiter().GetResult();
            }
            return pesan;
        }
    }
}
