using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class ObatManager
    {
        private ApiClient<Obat> _api;

        // Nanti tambahin validasi inputan

        public ObatManager()
        {
            _api = ApiClient<Obat>.GetInstance();
        }

        public async Task<ApiResponse<List<Obat>>> GetObat()
        {
            return await _api.Get("Obat");
        }

        public async Task<ApiResponse<Obat>> AddObat(Obat obat)
        {
            return await _api.Post("Obat", obat);
        }

        public async Task<ApiResponse<Obat>> EditObat(Obat obat)
        {
            return await _api.Put($"Obat/{obat.kode}", obat);
        }

        public async Task<ApiResponse<Obat>> DeleteObat(string kode)
        {
            return await _api.Delete($"Obat/{kode}");
        }
    }
}
