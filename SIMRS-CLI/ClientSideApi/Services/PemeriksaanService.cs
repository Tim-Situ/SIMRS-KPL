using SIMRS_API;
using SIMRS_LIB;
using System.Diagnostics;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PemeriksaanService : BaseService
    {
        ApiClient<Pemeriksaan> api = new();
        ApiClient<Pasien> apiPasien = new();
        ApiClient<Dokter> apiDokter = new();
        ApiClient<Obat> apiObat = new();
        string pesan = "";

        TableUtils tblPemeriksaan = new(new List<string>
        {
            "No",
            "Kode Pemeriksaan",
            "Pasien",
            "Dokter",
            "Tanggal",
            "Tinggi Badan",
            "Berat Badan",
            "Tekanan Darah",
            "Keluhan",
            "Diagnosa",
            "Obat"
        });
        public override void ShowAll()
        {
            int no = 1;
            List<Pemeriksaan> dataPemeriksaan = api.ClientGetData("Pemeriksaan").GetAwaiter().GetResult().data;
            foreach (Pemeriksaan pemeriksaan in dataPemeriksaan)
            {
                tblPemeriksaan.AddData(new List<string> {
                    no.ToString(), pemeriksaan.kode, pemeriksaan.pasien.nama, pemeriksaan.dokter.nama,
                    pemeriksaan.tanggal, pemeriksaan.tinggiBadan.ToString(), pemeriksaan.beratBadan.ToString(),
                    pemeriksaan.tekananDarah.ToString(), pemeriksaan.keluhan, pemeriksaan.diagnosa, pemeriksaan.obat.nama });
                no++;
            }

            tblPemeriksaan.ShowData();
            tblPemeriksaan.ClearData();

            Console.Write((dataPemeriksaan.Count == 0) ? "Data masih kosong!\n\n" : "");
        }
        public void ShowOne(string id)
        {
            Pemeriksaan pemeriksaan = api.ClientGetOneData($"Pemeriksaan/{id}").GetAwaiter().GetResult().data;
            tblPemeriksaan.AddData(new List<string> {
                "1", pemeriksaan.kode, pemeriksaan.pasien.nama, pemeriksaan.dokter.nama,
                pemeriksaan.tanggal, pemeriksaan.tinggiBadan.ToString(), pemeriksaan.beratBadan.ToString(),
                pemeriksaan.tekananDarah.ToString(), pemeriksaan.keluhan, pemeriksaan.diagnosa, pemeriksaan.obat.nama });
            tblPemeriksaan.ShowData();
            tblPemeriksaan.ClearData();
        }
        public override string Create()
        {
            Console.WriteLine("======= Tambah Data Pemeriksaan ========");

            string kode = PromptUser("Kode Pemeriksaan: ");
            Pasien pasien = ValidasiInputKode<Pasien>(apiPasien, "NIK pasien: ");
            Dokter dokter = ValidasiInputKode<Dokter>(apiDokter, "NIP dokter: ");
            string tanggal = PromptUser("Tanggal: ");
            double tinggiBadan = Convert.ToDouble(PromptUser("Tinggi Badan: "));
            while (!AngkaPositif(tinggiBadan))
            {
                Console.WriteLine("Tinggi badan harus positif");
                tinggiBadan = Convert.ToDouble(PromptUser("Tinggi Badan: "));
            }
            Debug.Assert(tinggiBadan > 0, "Tinggi badan tidak valid");
            double beratBadan = Convert.ToDouble(PromptUser("Berat Badan: "));
            while (!AngkaPositif(beratBadan))
            {
                Console.WriteLine("Berat badan harus positif");
                beratBadan = Convert.ToDouble(PromptUser("Berat Badan: "));
            }
            Debug.Assert(beratBadan > 0, "Berat badan tidak valid");
            string tekananDarah = PromptUser("Tekanan Darah: ");
            string keluhan = PromptUser("Keluhan: ");
            string diagnosa = PromptUser("Diagnosa: ");
            Obat obat = ValidasiInputKode<Obat>(apiObat, "Kode obat: ");

            pesan = "Data pemeriksaan gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                Pemeriksaan pemeriksaan = new Pemeriksaan(kode, pasien, dokter, tanggal, tinggiBadan, beratBadan, tekananDarah, keluhan, diagnosa, obat);
                pesan = api.ClientPostData(pemeriksaan, "Pemeriksaan").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Delete()
        {
            string kodePemeriksaan = PromptUser("Masukan kode pemeriksaan: ");
            pesan = "Data pemeriksaan gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Pemeriksaan/{kodePemeriksaan}").GetAwaiter().GetResult();
            }
            return pesan;
        }
    }
}
