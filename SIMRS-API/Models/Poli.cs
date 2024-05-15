using System;
using System.Text.Json;

namespace SIMRS_API;

public class Poli
{
	public string kode { get; set; }
	public string namaPoli { get; set; }
	public string ruang { get; set; }
	public int biaya { get; set; }

	public Poli(string kode, string namaPoli, string ruang, int biaya)
	{
		this.kode = kode;
		this.namaPoli = namaPoli;
		this.ruang = ruang;
		this.biaya = biaya;
	}
}

