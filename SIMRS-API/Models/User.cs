using System;
namespace SIMRS_API;

public class User
{
	public enum EnumJenisKelamin { PRIA, WANITA};

	public string nama { get; set; }
	public string tglLahir { get; set; }
	public string noHp { get; set; }
	public EnumJenisKelamin jnsKelamin { get; set; }
	public string alamat { get; set; }


	public User(string nama, string tglLahir, string noHp, EnumJenisKelamin jnsKelamin, string alamat)
	{
		this.nama = nama;
		this.tglLahir = tglLahir;
		this.noHp = noHp;
		this.jnsKelamin = jnsKelamin;
		this.alamat = alamat;
	}
}

