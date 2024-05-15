using System.Diagnostics;
using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PembayaranService : BaseService
    {
        ApiClient<Pembayaran> api = new();
        ApiClient<Pemeriksaan> apiPemeriksaan = new();
        string pesan = "";

        TableUtils tblPembayaran = new(new List<string>
        {
            "No",
            "Kode",
            "Kode Pemeriksaan",
            "Total Biaya",
            "Uang Bayar"
        });

        public override void ShowAll()
        {
            int no = 1;
            List<Pembayaran> dataPembayaran = api.ClientGetData("Pembayaran").GetAwaiter().GetResult().data;
            foreach (Pembayaran pembayaran in dataPembayaran)
            {
                tblPembayaran.addData(new List<string> {
                    no.ToString(), pembayaran.kode, pembayaran.pemeriksaan.kode, pembayaran.getTotalBiaya().ToString(), pembayaran.uangBayar.ToString() });
                no++;
            }

            tblPembayaran.showData();
            tblPembayaran.clearData();

            Console.Write((dataPembayaran.Count == 0) ? "Data masih kosong!\n\n" : "");
        }

        public override string Create()
        {
            Console.WriteLine("======= Tambah Data Pembayaran ========");

            string kode = PromptUser("Kode: ");
            Pemeriksaan pemeriksaan = ValidasiInputKode<Pemeriksaan>(apiPemeriksaan, "Kode Pemeriksaan: ");
            Pembayaran pembayaran = new Pembayaran(kode, pemeriksaan);
            Console.WriteLine("Total Biaya: " + pembayaran.getTotalBiaya());
            int uangBayar = Convert.ToInt32(PromptUser("Uang Bayar: "));
            while (uangBayar < 0) {
                Console.WriteLine("Nominal harus lebih dari 0");
                uangBayar = Convert.ToInt32(PromptUser("Uang Bayar: "));
            }
            Debug.Assert(uangBayar > 0, "Nominal yang diinputkan tidak valid!");
            Console.WriteLine("Kembalian: " + pembayaran.getUangKembalian(uangBayar));
            pembayaran.uangBayar = uangBayar;


            pesan = "Data pembayaran gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                pesan = api.ClientPostData(pembayaran, "Pembayaran").GetAwaiter().GetResult();
            }
            return pesan;
        }

        public override string Delete()
        {
            string kodePembayaran = PromptUser("Masukan kode pembayaran: ");
            pesan = "Data pembayaran gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Pembayaran/{kodePembayaran}").GetAwaiter().GetResult();
            }
            return pesan;
        }

    }
}
