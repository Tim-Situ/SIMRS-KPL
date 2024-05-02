using System;
namespace SIMRS_API;

public class Pasien : User
{
	public string kode { get; set; }

	public Pasien(string kode, string nama, string tglLahir, string noHp, EnumJenisKelamin jnsKelamin, string alamat) : base(nama, tglLahir, noHp, jnsKelamin, alamat)
    {
		this.kode = kode;
	}
}

