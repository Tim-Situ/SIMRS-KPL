﻿using System.Text.Json;

namespace SIMRS_LIB;

public static class JsonUtils<T>
{
    public static T ReadJsonFromFile(String filepath)
    {
        // membaca file json
        string jsonString = File.ReadAllText(filepath);
        // deserialize file json menjadi object
        T data = JsonSerializer.Deserialize<T>(jsonString);
        return data;
    }

    public static void WriteJsonFile(T data, String filepath)
    {
        // menggunakan serializer bawaan c#
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        String jsonString = JsonSerializer.Serialize(data, options);
        // serialize object menjadi file json
        File.WriteAllText(filepath, jsonString);
    }

    public static void UpdateJsonFile(T data, String filepath)
    {
        String jsonString = JsonSerializer.Serialize(data);
        // serialize object menjadi file json
        File.WriteAllText(filepath, jsonString);
    }
}

/*
EXAMPLE TO USE:

1. JsonUtils<T>.ReadJsonFromFile(filepath);
2. JsonUtils<T>.WriteJsonFile(data, filepath);
3. JsonUtils<T>.WriteJsonFile(data, filepath);
*/