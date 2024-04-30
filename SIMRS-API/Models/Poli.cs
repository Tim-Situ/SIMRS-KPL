using System;
using System.Text.Json;

namespace SIMRS_API;

public class Poli
{
	public string namaPoli { get; set; }
	public string ruang { get; set; }

	public Poli(string namaPoli, string ruang)
	{
		this.namaPoli = namaPoli;
		this.ruang = ruang;
	}
}

