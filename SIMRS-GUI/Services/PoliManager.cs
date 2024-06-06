using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PoliManager
    {
        private ApiClient<Poli> _api;

        // Nanti tambahin validasi inputan

        public PoliManager()
        {
            _api = ApiClient<Poli>.GetInstance();
        }

        public async Task<ApiResponse<List<Poli>>> GetPoli()
        {
            return await _api.Get("Poli");
        }

        public async Task<ApiResponse<Poli>> AddPoli(Poli poli)
        {
            return await _api.Post("Poli", poli);
        }

        public async Task<ApiResponse<Poli>> EditPoli(Poli poli)
        {
            return await _api.Put($"Poli/{poli.kode}", poli);
        }

        public async Task<ApiResponse<Poli>> DeletePoli(string kode)
        {
            return await _api.Delete($"Poli/{kode}");
        }
    }
}
