using SIMRS_API;

namespace SIMRS_CLI.ClientSideApi.Services
{
    public abstract class BaseService
    {
        public string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public bool Confirmation(string message)
        {
            Console.Write(message + " [y/n]: ");
            string confirmation = Console.ReadLine().ToLower();
            return confirmation == "y";
        }

        public T ValidasiInputKode<T>(ApiClient<T> api, string message)
        {
            ApiResponse<T> respon;

            do
            {
                string kode = PromptUser(message);
                respon = api.ClientGetOneData(typeof(T).Name + "/" + kode).GetAwaiter().GetResult();
                if (!respon.success)
                {
                    Console.WriteLine($"Nama {typeof(T).Name} tidak ditemukan");
                }
            } while (!respon.success);
            return respon.data;
        }

        public static bool AngkaPositif(double angka)
        {
            return angka > 0;
        }

        public abstract void ShowAll();
        public abstract string Create();
        public abstract string Delete();

    }
}
