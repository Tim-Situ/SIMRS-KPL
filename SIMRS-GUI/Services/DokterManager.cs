using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class DokterManager
    {
        private ApiClient<Dokter> _api;

        // Nanti tambahin validasi inputan

        public DokterManager()
        {
            _api = ApiClient<Dokter>.GetInstance();
        }

        public async Task<ApiResponse<List<Dokter>>> GetDokter()
        {
            return await _api.Get("Dokter");
        }

        public async Task<ApiResponse<Dokter>> AddDokter(Dokter dokter)
        {
            return await _api.Post("Dokter", dokter);
        }

        public async Task<ApiResponse<Dokter>> EditDokter(Dokter dokter)
        {
            return await _api.Put($"Dokter/{dokter.nip}", dokter);
        }

        public async Task<ApiResponse<Dokter>> DeleteDokter(string nip)
        {
            return await _api.Delete($"Dokter/{nip}");
        }
    }
}
