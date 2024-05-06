using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
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

        public static async Task<T> ClientGetData(string path)
        {
            ApiResponse<T> listData = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                listData = await response.Content.ReadAsAsync<ApiResponse<T>>();
            }
            return listData.data;
        }

        public static async Task ClientPostData<U>(U data, string path)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, data);
            response.EnsureSuccessStatusCode();
        }

        public static async Task ClientPutData<V>(V data, string path)
        {

        }

        public static async Task<HttpStatusCode> ClientDeleteData(string path)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                path);
            return response.StatusCode;
        }
    }
}
