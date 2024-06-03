using Newtonsoft.Json;
using SIMRS_API;
using SIMRS_GUI.Auth;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace SIMRS_GUI
{
    public class ApiClient<T>
    {
        private static string token;
        private static HttpClient s_client;

        // Menerapkan singleton
        private ApiClient() { }
        private static ApiClient<T> _instance;
        private static readonly object _lock = new object();

        public static ApiClient<T> GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ApiClient<T>();
                        token = SessionManager.getToken();
                        s_client = new HttpClient();
                        s_client.BaseAddress = new Uri("http://localhost:5117/api/");
                        s_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                }
            }
            return _instance;
        }
        // Selesai persiapan singleton

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

        public Task<ApiResponse<T>> Post(string path, T data)
            => SendRequestAsync(HttpMethod.Post, path, data);

        public Task<ApiResponse<T>> Put(string path, T data)
            => SendRequestAsync(HttpMethod.Put, path, data);

        public Task<ApiResponse<T>> Delete(string path)
            => SendRequestAsync<T>(HttpMethod.Delete, path);
    }
}
