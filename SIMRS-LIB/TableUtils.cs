namespace SIMRS_LIB;

public class TableUtils
{
    public List<string> kolom { get; set; }
    public List<List<string>> data = new List<List<string>>();

    public TableUtils(List<string> kolom)
    {
        this.kolom = kolom;
    }

    public void AddData(List<string> data)
    {
        this.data.Add(data);
    }

    public void ClearData()
    {
        this.data.Clear();
    }

    public void ShowData()
    {
        string batas = "";

        List<int> lebarMax = new List<int>();

        foreach (string judul in kolom)
        {
            lebarMax.Add(judul.Length);
        }

        foreach (List<string> row in data)
        {
            for (int i = 0; i < row.Count; i++)
            {
                int length = row[i].Length;
                if (length > lebarMax[i])
                {
                    lebarMax[i] = length;
                }
            }
        }

        for (int i = 0; i < lebarMax.Count; i++)
        {
            batas += "+";
            for (int j = 0; j < lebarMax[i] + 2; j++)
            {
                batas += "-";
            }
        }

        batas += "-+";
        Console.WriteLine(batas);

        for (int i = 0; i < lebarMax.Count; i++)
        {
            Console.Write($"| {kolom[i].PadRight(lebarMax[i] + 1)}");
        }
        Console.WriteLine(" |");
        Console.WriteLine(batas);

        foreach (List<string> row in data)
        {
            for (int i = 0; i < row.Count; i++)
            {
                Console.Write($"| {row[i].PadRight(lebarMax[i] + 1)}");
            }
            Console.WriteLine(" |");
            Console.WriteLine(batas);
        }

    }

}


/* Cara Pakai
 
List<String> kolom = new List<string>
{
    "Nama",
    "Tanggal Lahir",
    "No Hp",
    "Jenis Kelamin",
    "Alamat",
    "NIP",
    "Poli"
};

TableUtils tblDokter = new TableUtils(kolom);

foreach(Dokter dokter in dataDokter)
{
    tblDokter.AddData(new List<string> {dokter.nama, dokter.tglLahir, dokter.noHp, dokter.jnsKelamin.ToString(), dokter.alamat, dokter.nip, dokter.poli.namaPoli });
}

tblDokter.ShowData();

*/