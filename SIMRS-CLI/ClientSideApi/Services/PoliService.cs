using SIMRS_API;
using SIMRS_LIB;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal class PoliService : BaseService
    {
        ApiClient<Poli> api = new();

        TableUtils tblPoli = new(new List<string>
                {
                    "No",
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
                tblPoli.addData(new List<string> { no.ToString(), Poli.namaPoli, Poli.ruang, Poli.biaya.ToString()});
                no++;
            }

            tblPoli.showData();
            tblPoli.clearData();
        }

        public override void ShowOne(string id)
        {
            Poli Poli = api.ClientGetOneData($"Poli/{id}").GetAwaiter().GetResult().data;
            tblPoli.addData(new List<string> { "1", Poli.namaPoli, Poli.ruang, Poli.biaya.ToString() });
            tblPoli.showData();
            tblPoli.clearData();
        }

        public override void Create()
        {
            Console.WriteLine("======= Tambah Data Poli ========");

            string kode = PromptUser("Kode: ");
            string namaPoli = PromptUser("Nama Poli: ");
            string ruang = PromptUser("Ruang: ");
            int biaya = Convert.ToInt32(PromptUser("Biaya: "));

            Poli Poli= new Poli(kode, namaPoli, ruang, biaya);
            api.ClientPostData(Poli, "Poli").GetAwaiter().GetResult();
        }

        public override void Update()
        {
            int kodePoli;
            Console.WriteLine("Masukan kode spesialis yang ingin diedit!");
            kodePoli = Convert.ToInt32(Console.ReadLine());
            Poli poli= api.ClientGetOneData($"Poli/{kodePoli}").GetAwaiter().GetResult().data;
            Console.Clear();
            ShowOne(kodePoli.ToString());

            Console.WriteLine("Masukan data baru");
            string namaPoli = PromptUser("Nama Poli: ");
            string ruang = PromptUser("Ruang: ");
            int biaya = Convert.ToInt32(PromptUser("Biaya: "));

            poli.namaPoli = namaPoli ?? poli.namaPoli;
            poli.ruang = ruang ?? poli.ruang;
            poli.biaya = biaya != 0 ? biaya : poli.biaya;

            api.ClientPutData(poli, $"Poli/{kodePoli}").GetAwaiter().GetResult();
        }

        public override void Delete()
        {
            int kodePoli;
            Console.WriteLine("Masukan kode spesialis yang ingin dihapus!");
            kodePoli = Convert.ToInt32(Console.ReadLine());
            Poli poli = api.ClientGetOneData($"Poli/{kodePoli}").GetAwaiter().GetResult().data;

            if (Confirmation($"Apakah anda yakin ingin menghapus spesialis dengan kode {poli.kode}"))
            {
                var statusCode = api.ClientDeleteData($"Poli/{kodePoli}").GetAwaiter().GetResult();
                Console.WriteLine($"Deleting... (HTTP Status = {(int)statusCode})");
            }
        }
    }
}
