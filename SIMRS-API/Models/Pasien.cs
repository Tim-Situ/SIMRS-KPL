using System;
namespace SIMRS_API;

public class Pasien : User
{
	public string nik { get; set; }

	public Pasien(string nik, string nama, string tglLahir, string noHp, EnumJenisKelamin jnsKelamin, string alamat) : base(nama, tglLahir, noHp, jnsKelamin, alamat)
    {
		this.nik = nik;
	}
}

