using Newtonsoft.Json;
using SIMRS_API;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SIMRS_CLI.ClientSideApi
{
    public class ApiClient<T>
    {
        private static readonly HttpClient client = new HttpClient()
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

            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(jsonResponse);
        }

        public Task<ApiResponse<List<T>>> ClientGetData(string path) => SendRequestAsync<List<T>>(HttpMethod.Get, path);

        public Task<ApiResponse<T>> ClientGetOneData(string path) => SendRequestAsync<T>(HttpMethod.Get, path);

        public async Task<string> ClientPostData(T data, string path)
        {
            var response = await SendRequestAsync<T>(HttpMethod.Post, path, data);
            return response.message;
        }

        public async Task<string> ClientPutData(T data, string path)
        {
            var response = await SendRequestAsync<T>(HttpMethod.Put, path, data);
            return response.message;
        }

        public async Task<string> ClientDeleteData(string path)
        {
            var response = await SendRequestAsync<T>(HttpMethod.Delete, path);
            return response.message;
        }
    }
}
