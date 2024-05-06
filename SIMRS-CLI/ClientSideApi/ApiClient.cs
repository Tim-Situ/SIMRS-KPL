using System.Net;
using SIMRS_API;

namespace SIMRS_CLI.ClientSideApi
{
    public class ApiClient<T>
    {
        // TO DO: Menambah try catch

        protected static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:5117/api/")
        };

        public async Task<ApiResponse<List<T>>> ClientGetData(string path)
        {
            ApiResponse<List<T>> listData = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                listData = await response.Content.ReadAsAsync<ApiResponse<List<T>>>();
            }
            else
            {
                
            }
            return listData;
        }

        public async Task<ApiResponse<T>> ClientGetOneData(string path)
        {
            ApiResponse<T> listData = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                listData = await response.Content.ReadAsAsync<ApiResponse<T>>();
            }
            return listData;
        }

        public async Task ClientPostData<U>(U data, string path)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, data);
            response.EnsureSuccessStatusCode();
        }

        public async Task ClientPutData<V>(V data, string path)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
               path, data);
            response.EnsureSuccessStatusCode();
        }

        public async Task<HttpStatusCode> ClientDeleteData(string path)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                path);
            return response.StatusCode;
        }
    }
}
