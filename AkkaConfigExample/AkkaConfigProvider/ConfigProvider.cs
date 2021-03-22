using Microsoft.Extensions.Configuration;

namespace AkkaConfigProvider
{
    class ConfigProvider
    {
        private readonly IConfiguration _configuration;
        public string BaseDir { get; }
        public ConfigProvider(string baseDir, string filename)
        {
            
        }

        public ConfigProvider(string filename)
        {
            
        }

        public ConfigProvider()
        {
            
        }
    }
}