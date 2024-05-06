using System;
namespace SIMRS_API.Models
{
	public class Pembayaran
	{
		public string kode { get; set; }
		public Pemeriksaan pemeriksaan { get; set; }
		public int uangBayar { get; set; }

        public Pembayaran(string kode, Pemeriksaan pemeriksaan, int uangBayar)
        {
            this.kode = kode;
            this.pemeriksaan = pemeriksaan;
            this.uangBayar = uangBayar;
        }
    }
}

