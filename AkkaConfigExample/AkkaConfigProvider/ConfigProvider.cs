using System;
using System.IO;
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
            string baseDir = GetBaseDir();
        }

        public ConfigProvider()
        {
            string baseDir = GetBaseDir();
        }

        private string GetBaseDir()
        {
            var currDir = Directory.GetCurrentDirectory();
            var lastIndex = currDir.LastIndexOf("bin", StringComparison.InvariantCultureIgnoreCase);
            var projectDir =
                lastIndex < 0
                    ? currDir
                    : currDir.Substring(0, currDir.LastIndexOf("bin", StringComparison.InvariantCultureIgnoreCase));

            return projectDir;
        }
    }
}