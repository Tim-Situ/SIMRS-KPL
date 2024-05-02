using System.Net.Http.Headers;
using SIMRS_API;

namespace SIMRS_CLI
{
    internal class ApiClient
    {
        static HttpClient client = new HttpClient();

        static void ShowPasien(Pasien pasien)
        {
            Console.WriteLine("Nama: " + pasien.nama);
        }

        static async Task<ApiResponse<List<Pasien>>> GetPasienAsync(string path)
        {
            ApiResponse<List<Pasien>> ApiDataPasien = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                ApiDataPasien = await response.Content.ReadAsAsync<ApiResponse<List<Pasien>>>();
            }
            return ApiDataPasien;
        }

        public static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:5117/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Get the pasien
                ApiResponse<List<Pasien>> ApiDataPasien = await GetPasienAsync("http://localhost:5117/api/Pasien");
                foreach (var pasien in ApiDataPasien.data)
                {
                    ShowPasien(pasien);  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
