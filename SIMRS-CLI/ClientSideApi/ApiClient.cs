using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SIMRS_API;

namespace SIMRS_CLI.ClientSideApi
{
    public class ApiClient<T>
    {
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
    }
}
