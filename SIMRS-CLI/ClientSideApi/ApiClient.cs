using Newtonsoft.Json;
using SIMRS_API;

namespace SIMRS_CLI.ClientSideApi
{
    public class ApiClient<T>
    {
        protected static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5117/api/")
        };

        public async Task<ApiResponse<List<T>>> ClientGetData(string path)
        {
            ApiResponse<List<T>> listData = null;
            HttpResponseMessage response = await client.GetAsync(path);
            listData = await response.Content.ReadAsAsync<ApiResponse<List<T>>>();
            return listData;
        }

        public async Task<ApiResponse<T>> ClientGetOneData(string path)
        {
            ApiResponse<T> listData = null;
            HttpResponseMessage response = await client.GetAsync(path);
            listData = await response.Content.ReadAsAsync<ApiResponse<T>>();
            return listData;
        }

        public async Task<string> ClientPostData<T>(T data, string path)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, data);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(jsonResponse).message;
        }

        public async Task<string> ClientPutData<T>(T data, string path)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
               path, data);
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(jsonResponse).message;
        }

        public async Task<string> ClientDeleteData(string path)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                path);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiResponse<T>>(jsonResponse).message;
        }
    }
}
