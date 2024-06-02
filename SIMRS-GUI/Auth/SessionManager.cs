using SIMRS_API;

namespace SIMRS_GUI.Auth
{
    internal class SessionManager
    {
        private static string s_currentUser;
        private static string s_token;

        public async static Task Login(string username, string password)
        {
            ApiClient<Object> api = new();
            Admin admin = new Admin { username = username, password = password };
            ApiResponse<Object> response = await api.Post("Auth/login", admin);

            s_currentUser = username;
            s_token = response.data.ToString();
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
