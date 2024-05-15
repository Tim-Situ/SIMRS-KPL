using System;
namespace SIMRS_API;

public class Obat
{
    public enum EnumObat { PIL, SIRUP, TABLET };

    public string kode { get; set; }
	public string nama { get; set; }
	public int harga { get; set; }
	public EnumObat jenis { get; set; }

    public Obat(string kode, string nama, int harga, EnumObat jenis)
    {
        this.kode = kode;
        this.nama = nama;
        this.harga = harga;
        this.jenis = jenis;
    }
}

