using System;
namespace SIMRS_API;

public class Pemeriksaan
{
	public string kode { get; set; }
	public Pasien pasien { get; set; }
	public Dokter dokter { get; set; }
	public string tanggal { get; set; }
	public float tinggiBadan { get; set; }
	public float beratBadan { get; set; }
	public float tekananDarah { get; set; }
	public string keluhan { get; set; }
	public string diagnosa { get; set; }
	public Obat obat { get; set; }

    public Pemeriksaan(string kode, Pasien pasien, Dokter dokter, string tanggal, float tinggiBadan, float beratBadan, float tekananDarah, string keluhan, string diagnosa, Obat obat)
    {
        this.kode = kode;
        this.pasien = pasien;
        this.dokter = dokter;
        this.tanggal = tanggal;
        this.tinggiBadan = tinggiBadan;
        this.beratBadan = beratBadan;
        this.tekananDarah = tekananDarah;
        this.keluhan = keluhan;
        this.diagnosa = diagnosa;
        this.obat = obat;
    }
}

