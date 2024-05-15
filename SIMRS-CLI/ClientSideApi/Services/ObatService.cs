using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class ObatService : BaseService
    {
        ApiClient<Obat> api = new();
        string pesan = "";

        TableUtils tblObat = new(new List<string>
        {
            "No",
            "Kode",
            "Nama",
            "Harga",
            "Jenis"
        });
        public override void ShowAll()
        {
            int no = 1;
            List<Obat> dataObat = api.ClientGetData("Obat").GetAwaiter().GetResult().data;
            foreach (Obat obat in dataObat)
            {
                tblObat.addData(new List<string> { no.ToString(), obat.kode, obat.nama, obat.harga.ToString(), obat.jenis.ToString() });
                no++;
            }

            tblObat.showData();
            tblObat.clearData();

            Console.Write((dataObat.Count == 0) ? "Data masih kosong!\n\n" : "");
        }
        public void ShowOne(string id)
        {
            Obat obat = api.ClientGetOneData($"Obat/{id}").GetAwaiter().GetResult().data;
            tblObat.addData(new List<string> { "1", obat.kode, obat.nama, obat.harga.ToString(), obat.jenis.ToString() });
            tblObat.showData();
            tblObat.clearData();
        }
        public override string Create()
        {
            Console.WriteLine("======= Tambah Data Obat ========");

            string kode = PromptUser("Kode: ");
            string namaObat = PromptUser("Nama Obat: ");
            int harga = Convert.ToInt32(PromptUser("Harga: "));
            string _jenis = PromptUser("Jenis: ").ToUpper();
            Obat.EnumObat jenis = Enum.Parse<Obat.EnumObat>(_jenis);

            pesan = "Data obat gagal ditambahkan";
            if (Confirmation("Simpan Data?"))
            {
                Obat obat = new Obat(kode, namaObat, harga, jenis);
                pesan = api.ClientPostData(obat, "Obat").GetAwaiter().GetResult();
            }
            return pesan;
        }
        public string Update()
        {
            string kodeObat = PromptUser("Masukan kode obat: ");
            ApiResponse<Obat> respon = api.ClientGetOneData($"Obat/{kodeObat}").GetAwaiter().GetResult();
            if (!respon.success)
            {
                return respon.message;
            }
            Obat obat = respon.data;
            Console.Clear();
            ShowOne(kodeObat);

            Console.WriteLine("Masukan data baru");
            string namaObat = PromptUser("Nama Obat: ");
            string _harga = PromptUser("Harga: ");
            string _jenis = PromptUser("Jenis: ").ToUpper();

            obat.nama = (namaObat == "") ? obat.nama : namaObat;
            obat.harga = (_harga == "") ? obat.harga : Convert.ToInt32(_harga);
            if (_jenis != "")
            {
                obat.jenis = Enum.Parse<Obat.EnumObat>(_jenis);
            }

            pesan = "Data obat gagal diubah";
            if (Confirmation("Edit Data?"))
            {
                pesan = api.ClientPutData(obat, $"Obat/{kodeObat}").GetAwaiter().GetResult();
            }
            return pesan;
        }
        public override string Delete()
        {
            string kodeObat = PromptUser("Masukan kode obat: ");
            pesan = "Data obat gagal dihapus";
            if (Confirmation("Hapus Data?"))
            {
                pesan = api.ClientDeleteData($"Obat/{kodeObat}").GetAwaiter().GetResult();
            }
            return pesan;
        }

    }
}

