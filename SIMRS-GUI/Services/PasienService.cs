using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PasienService
    {
        public async Task<ApiResponse<List<Pasien>>> GetPasien()
        {
            ApiClient<Pasien> api = new();
            return await api.Get("Pasien");
        }
    }
}
