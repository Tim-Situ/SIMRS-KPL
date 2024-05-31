using Newtonsoft.Json;
using SIMRS_API;
using System.Net.Http.Json;

namespace SIMRS_GUI
{
    public class ApiClient<T>
    {
        private static readonly HttpClient s_client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5117/api/")
        };

        private async Task<ApiResponse<T>> SendRequestAsync<T>(HttpMethod method, string path, T data = default)
        {
            HttpRequestMessage request = new HttpRequestMessage(method, path);
            if (data != null && (method == HttpMethod.Post || method == HttpMethod.Put))
            {
                request.Content = JsonContent.Create(data);
            }

            HttpResponseMessage response = await s_client.SendAsync(request);

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(jsonResponse);
        }

        public Task<ApiResponse<List<T>>> Get(string path)
            => SendRequestAsync<List<T>>(HttpMethod.Get, path);

        public Task<ApiResponse<T>> GetOne(string path)
            => SendRequestAsync<T>(HttpMethod.Get, path);

        public Task<ApiResponse<T>> Post(T data, string path)
            => SendRequestAsync(HttpMethod.Post, path, data);


        public Task<ApiResponse<T>> Put(T data, string path)
            => SendRequestAsync(HttpMethod.Put, path, data);

        public Task<ApiResponse<T>> Delete(string path)
            => SendRequestAsync<T>(HttpMethod.Delete, path);
    }
}
