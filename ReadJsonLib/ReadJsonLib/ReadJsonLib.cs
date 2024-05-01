using System.Text.Json;

namespace ReadJsonLib;

public class ReadJsonLib<T>
{
    public T ReadJsonFromFile(String path)
    {
        string filepath = path;
        // membaca file json
        string jsonString = File.ReadAllText(filepath);
        // deserialize file json menjadi object
        T data = JsonSerializer.Deserialize<T>(jsonString);
        return data;
    }
}

/*
EXAMPLE TO USE:

ReadJsonLib<Mahasiswa> mhs = new ReadJsonLib<Mahasiswa>();
Mahasiswa mhsnew = mhs.ReadJson("../../../data.json");
Console.WriteLine(mhsnew.nim);
*/