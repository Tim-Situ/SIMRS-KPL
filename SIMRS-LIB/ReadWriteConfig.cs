using System.Text.Json;

namespace SIMRS_LIB
{
    public class ReadWriteConfig<T>
    {
        public T config;

        public ReadWriteConfig(T defautConfig, string filepath)
        {
            try
            {
                config = JsonUtils<T>.ReadJsonFromFile(filepath);
            }
            catch (Exception)
            {
                config = defautConfig;
                JsonUtils<T>.WriteJsonFile(defautConfig, filepath);
            }
        }
    }
}

