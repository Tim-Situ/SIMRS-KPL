using SIMRS_LIB;

namespace SIMRS_LIB
{
    public class ReadWriteUtils<T>
    {
        public T config;

        public ReadWriteUtils(T defaultConfig, string filepath)
        {
            try
            {
                config = JsonUtils<T>.ReadJsonFromFile(filepath);
            }
            catch (Exception)
            {
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