using System;
namespace SIMRS_API;

public class Pembayaran
{
	public string kode { get; set; }
	public Pemeriksaan pemeriksaan { get; set; }
    public int uangBayar = 0;

    public Pembayaran(string kode, Pemeriksaan pemeriksaan)
    {
        this.kode = kode;
        this.pemeriksaan = pemeriksaan;
    }

    public int getTotalBiaya()
    {
        return pemeriksaan.dokter.poli.biaya + pemeriksaan.obat.harga;
    }

    public int getUangKembalian(int uang)
    {
        return uang - (pemeriksaan.dokter.poli.biaya + pemeriksaan.obat.harga);
    }
}

