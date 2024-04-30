using System;
namespace SIMRS_API;

public class Dokter : User
{
	public string nip { get; set; }
	public Poli poli { get; set; }

    public Dokter(string nip, string nama, Poli poli, string tglLahir, string noHp, EnumJenisKelamin jnsKelamin, string alamat) : base(nama, tglLahir, noHp, jnsKelamin, alamat)
    {
        this.nip = nip;
        this.poli = poli;
    }
}

