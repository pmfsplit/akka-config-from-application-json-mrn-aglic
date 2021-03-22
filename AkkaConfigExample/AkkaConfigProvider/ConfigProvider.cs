﻿using System;
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
            _configuration = GetConfiguration(filename, baseDir);
        }

        public ConfigProvider(string filename)
        {
            string baseDir = GetBaseDir();
            _configuration = GetConfiguration(filename, baseDir);
        }

        public ConfigProvider()
        {
            string baseDir = GetBaseDir();
            string defaultfilename = "appsettings.json";
            _configuration = GetConfiguration(defaultfilename, baseDir);
        }

        private IConfiguration GetConfiguration(string filename, string baseDir)
        {
            return new ConfigurationBuilder()
                .SetBasePath(baseDir)
                .AddJsonFile($"{baseDir}/{filename}")
                .Build();
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