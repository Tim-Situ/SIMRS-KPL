using System.Text.Json;

namespace SIMRS_LIB;

// Library utuk membaca dan menulis Json
public static class JsonUtils<T>
{
    // method untuk membaca json dari file
    public static T ReadJsonFromFile(string filepath)
    {
        // membaca file json
        string jsonString = File.ReadAllText(filepath);
        // deserialize file json menjadi object
        T data = JsonSerializer.Deserialize<T>(jsonString);
        return data;
    }

    // method untuk menulis json ke file
    public static void WriteJsonFile(T data, string filepath)
    {
        // menggunakan serializer bawaan c#
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string jsonString = JsonSerializer.Serialize(data, options);
        // serialize object menjadi file json
        File.WriteAllText(filepath, jsonString);
    }
}

/*
EXAMPLE TO USE:

1. JsonUtils<T>.ReadJsonFromFile(filepath);
2. JsonUtils<T>.WriteJsonFile(data, filepath);
*/