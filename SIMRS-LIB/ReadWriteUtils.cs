using SIMRS_LIB;

namespace SIMRS_LIB
{
    // Library Untuk Membaca dan Menulis File Konfigurasi
    public class ReadWriteUtils<T>
    {
        public T config;

        public ReadWriteUtils(T defaultConfig, string filepath)
        {
            // method untuk membaca file dan menulis file baru jika belum ada
            try
            {
                // Method untuk membaca file konfigurasi
                config = JsonUtils<T>.ReadJsonFromFile(filepath);
            }
            catch (Exception)
            {
                // method untuk menulis file konfigurasi
                config = defaultConfig;
                JsonUtils<T>.WriteJsonFile(defaultConfig, filepath);
            }
        }
    }
}

/*
EXAMPLE TO USE:

ReadWriteUtils<T> ReadWrite =
    new ReadWriteUtils<T>(
        DdefautConfig,
        filepath
        );
Console.WriteLine(ReadWrite.config.var1);
*/