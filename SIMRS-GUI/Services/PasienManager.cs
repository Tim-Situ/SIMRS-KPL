using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PasienManager
    {
        ApiClient<Pasien> api;

        public PasienManager()
        {
            api = ApiClient<Pasien>.GetInstance();
        }

        public async Task<ApiResponse<List<Pasien>>> GetPasien()
        {
            return await api.Get("Pasien");
        }
    }
}
