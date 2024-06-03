using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PasienService
    {
        ApiClient<Pasien> api;

        public PasienService()
        {
            api = ApiClient<Pasien>.GetInstance();
        }

        public async Task<ApiResponse<List<Pasien>>> GetPasien()
        {
            return await api.Get("Pasien");
        }
    }
}
