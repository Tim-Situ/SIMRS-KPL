using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PemeriksaanManager
    {
        private ApiClient<Pemeriksaan> _api;

        // Nanti tambahin validasi inputan

        public PemeriksaanManager()
        {
            _api = ApiClient<Pemeriksaan>.GetInstance();
        }

        public async Task<ApiResponse<List<Pemeriksaan>>> GetPemeriksaan()
        {
            return await _api.Get("Pemeriksaan");
        }

        public async Task<ApiResponse<Pemeriksaan>> AddPemeriksaan(Pemeriksaan pemeriksaan)
        {
            return await _api.Post("Pemeriksaan", pemeriksaan);
        }

        public async Task<ApiResponse<Pemeriksaan>> EditPemeriksaan(Pemeriksaan pemeriksaan)
        {
            return await _api.Put($"Pemeriksaan/{pemeriksaan.kode}", pemeriksaan);
        }

        public async Task<ApiResponse<Pemeriksaan>> DeletePemeriksaan(string kode)
        {
            return await _api.Delete($"Pemeriksaan/{kode}");
        }
    }
}
