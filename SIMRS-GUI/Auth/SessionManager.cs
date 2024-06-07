using SIMRS_API;

namespace SIMRS_GUI.Auth
{
    internal class SessionManager
    {
        private static string s_currentUser;
        private static string s_token;

        public async static Task<ApiResponse<Object>> Login(string username, string password)
        {
            ApiClient<Object> api = ApiClient<Object>.GetInstance();
            Admin admin = new Admin { username = username, password = password };
            ApiResponse<Object> response = await api.Post("Auth/login", admin);
            if (response.success)
            {
                s_currentUser = username;
                s_token = response.data.ToString();
            }
            return response;
        }

        public static string getUsername()
        {
            return s_currentUser;
        }
        public static string getToken()
        {
            return s_token;
        }
    }
}
