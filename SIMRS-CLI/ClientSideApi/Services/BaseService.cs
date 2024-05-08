using SIMRS_API;

namespace SIMRS_CLI.ClientSideApi.Services
{
    internal abstract class BaseService
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
            ApiResponse<List<T>> respon;
            T data = default;

            do
            {
                string kode = PromptUser(message);
                respon = api.ClientGetData(data.GetType().Name + "/" + kode).GetAwaiter().GetResult();
                if (!respon.success)
                {
                    Console.WriteLine($"Nama {data.GetType().Name} tidak ditemukan");
                }
            } while (!respon.success);
            return respon.data[0];
        }

        public abstract void ShowAll();
        public abstract void ShowOne(string id);
        public abstract string Create();
        public abstract string Update();
        public abstract string Delete();

    }
}
