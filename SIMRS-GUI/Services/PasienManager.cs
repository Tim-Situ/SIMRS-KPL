using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PasienManager
    {
        private ApiClient<Pasien> _api;

        // Nanti tambahin validasi inputan

        public PasienManager()
        {
            _api = ApiClient<Pasien>.GetInstance();
        }

        public async Task<ApiResponse<List<Pasien>>> GetPasien()
        {
            return await _api.Get("Pasien");
        }

        public async Task<ApiResponse<Pasien>> AddPasien(Pasien pasien)
        {
            return await _api.Post("Pasien", pasien);
        }

        public async Task<ApiResponse<Pasien>> EditPasien(Pasien pasien)
        {
            return await _api.Put($"Pasien/{pasien.nik}", pasien);
        }

        public async Task<ApiResponse<Pasien>> DeletePasien(string nik)
        {
            return await _api.Delete($"Pasien/{nik}");
        }
    }
}
