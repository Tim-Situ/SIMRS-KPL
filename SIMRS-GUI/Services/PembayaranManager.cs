using SIMRS_API;

namespace SIMRS_GUI.Services
{
    internal class PembayaranManager
    {
        private ApiClient<Pembayaran> _api;

        // Nanti tambahin validasi inputan

        public PembayaranManager()
        {
            _api = ApiClient<Pembayaran>.GetInstance();
        }

        public async Task<ApiResponse<List<Pembayaran>>> GetPembayaran()
        {
            return await _api.Get("Pembayaran");
        }

        public async Task<ApiResponse<Pembayaran>> AddPembayaran(Pembayaran pembayaran)
        {
            return await _api.Post("Pembayaran", pembayaran);
        }

        public async Task<ApiResponse<Pembayaran>> EditPembayaran(Pembayaran pembayaran)
        {
            return await _api.Put($"Pembayaran/{pembayaran.kode}", pembayaran);
        }

        public async Task<ApiResponse<Pembayaran>> DeletePembayaran(string kode)
        {
            return await _api.Delete($"Pembayaran/{kode}");
        }
    }
}
