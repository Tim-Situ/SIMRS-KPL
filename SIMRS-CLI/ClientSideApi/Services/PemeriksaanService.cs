//using SIMRS_API;
//using SIMRS_LIB;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SIMRS_CLI.ClientSideApi.Services
//{
//    internal class PemeriksaanService : BaseService
//    {
//        ApiClient<Pemeriksaan> api = new();
//        string pesan = "";

//        TableUtils tblPemeriksaan = new(new List<string>
//        {
//            "No",
//            "Kode Pemeriksaan",
//            "Pasien",
//            "Dokter",
//            "Tanggal",
//            "Tinggi Badan",
//            "Berat Badan",
//            "Tekanan Darah",
//            "Keluhan",
//            "Diagnosa",
//            "Obat"
//        });
//        public override void ShowAll()
//        {
//            int no = 1;
//            List<Pemeriksaan> dataPemeriksaan = api.ClientGetData("Pemeriksaan").GetAwaiter().GetResult().data;
//            foreach (Pemeriksaan pemeriksaan in dataPemeriksaan)
//            {
//                //tblPemeriksaan.addData(new List<string> { no.ToString(), pemeriksaan.kode, pemeriksaan.pasien, pemeriksaan.dokter, pemeriksaan.tanggal, pemeriksaan.tinggiBadan.ToString(), pemeriksaan.beratBadan.ToString(), pemeriksaan.tekananDarah.ToString(), pemeriksaan.keluhan, pemeriksaan.diagnosa, pemeriksaan.obat});
//                //no++;
//            }

//            tblPemeriksaan.showData();
//            tblPemeriksaan.clearData();

//            Console.Write((dataPemeriksaan.Count == 0) ? "Data masih kosong!\n\n" : "");
//        }
//        public override void ShowOne(string id)
//        {
//            Pemeriksaan pemeriksaan = api.ClientGetOneData($"Pemeriksaan/{id}").GetAwaiter().GetResult().data;
//            //tblPemeriksaan.addData(new List<string> { "1", pemeriksaan.kode, pemeriksaan.pasien, pemeriksaan.dokter, pemeriksaan.tanggal, pemeriksaan.tinggiBadan.ToString(), pemeriksaan.beratBadan.ToString(), pemeriksaan.tekananDarah.ToString(), pemeriksaan.keluhan, pemeriksaan.diagnosa, pemeriksaan.obat});
//            tblPemeriksaan.showData();
//            tblPemeriksaan.clearData();
//        }
//        public override string Create()
//        {
//            Console.WriteLine("======= Tambah Data Pemeriksaan ========");

//            string kode = PromptUser("Kode Pemeriksaan: ");
//            string pasien = PromptUser("Pasien: ");
//            string dokter = PromptUser("Dokter: ");
//            string tanggal = PromptUser("Tanggal: ");
//            int tinggiBadan = Convert.ToInt32(PromptUser("Tinggi Badan: "));
//            int beratBadan = Convert.ToInt32(PromptUser("Berat Badan: "));
//            int tekananDarah = Convert.ToInt32(PromptUser("Tekanan Darah: "));
//            string keluhan = PromptUser("Keluhan: ");
//            string diagnosa = PromptUser("Diagnosa: ");
//            string obat = PromptUser("Obat: ");

//            pesan = "Data pemeriksaan gagal ditambahkan";
//            if (Confirmation("Simpan Data?"))
//            {
//                Pemeriksaan pemeriksaan = new Pemeriksaan(kode, pasien, dokter, tanggal, tinggiBadan, beratBadan, tekananDarah, keluhan, diagnosa, obat);
//                pesan = api.ClientPostData(Pemeriksaan, "Pemeriksaan").GetAwaiter().GetResult();
//            }
//            return pesan;
//        }
//        public override string Update()
//        {
//            string kodePemeriksaan = PromptUser("Masukan kode pemeriksaan: ");
//            ApiResponse<Pemeriksaan> respon = api.ClientGetOneData($"Pemeriksaan/{kodePemeriksaan}").GetAwaiter().GetResult();
//            if (!respon.success)
//            {
//                return respon.message;
//            }
//            Pemeriksaan pemeriksaan = respon.data;
//            Console.Clear();
//            ShowOne(kodePemeriksaan);

//            Console.WriteLine("Masukan data baru");
//            string pasien = PromptUser("Pasien: ");
//            string dokter = PromptUser("Dokter: ");
//            string tanggal = PromptUser("Tanggal: ");
//            string _tinggiBadan = PromptUser("Tinggi Badan: ");
//            string _beratBadan = PromptUser("Berat Badan: ");
//            string _tekananDarah = PromptUser("Tekanan Darah: ");
//            string keluhan = PromptUser("Keluhan: ");
//            string diagnosa = PromptUser("Diagnosa: ");
//            string obat = PromptUser("Obat: ");

//            pemeriksaan.kode = (kodePemeriksaan == "") ? pemeriksaan.kode: kodePemeriksaan;
//            pemeriksaan.pasien = (pasien == "") ? pemeriksaan.pasien : pasien;
//            pemeriksaan.tanggal = (tanggal == "") ? pemeriksaan.tanggal : tanggal;
//            pemeriksaan.tinggiBadan = (_tinggiBadan == "") ? pemeriksaan.tinggiBadan : Convert.ToInt32(_tinggiBadan);
//            pemeriksaan.beratBadan = (_beratBadan == "") ? pemeriksaan.beratBadan : Convert.ToInt32(_beratBadan);
//            pemeriksaan.tekananDarah = (_tekananDarah == "") ? pemeriksaan.tekananDarah : Convert.ToInt32(_tekananDarah);
//            pemeriksaan.keluhan = (keluhan == "") ? pemeriksaan.keluhan : keluhan;
//            pemeriksaan.diagnosa = (diagnosa == "") ? pemeriksaan.diagnosa : diagnosa;
//            pemeriksaan.obat = (obat == "") ? pemeriksaan.obat : obat;

//            pesan = "Data pemeriksaan gagal diubah";
//            if (Confirmation("Edit Data?"))
//            {
//                pesan = api.ClientPutData(poli, $"Pemeriksaan/{kodePemeriksaan}").GetAwaiter().GetResult();
//            }
//            return pesan;
//        }
//        public override string Delete()
//        {
//            string kodePemeriksaan = PromptUser("Masukan kode pemeriksaan: ");
//            pesan = "Data pemeriksaan gagal dihapus";
//            if (Confirmation("Hapus Data?"))
//            {
//                pesan = api.ClientDeleteData($"Pemeriksaan/{kodePemeriksaan}").GetAwaiter().GetResult();
//            }
//            return pesan;
//        }
//    }
//}
