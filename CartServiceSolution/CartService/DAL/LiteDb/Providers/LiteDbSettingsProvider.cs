using CartService.DAL.LiteDb.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace CartService.DAL.LiteDb.Providers
{
    public class LiteDbSettingsProvider : ILiteDbSettingsProvider
    {
        private string DbPath { get;}

        public LiteDbSettingsProvider(IConfiguration configuration)
        {
            DbPath = configuration.GetConnectionString("LiteDbConnectionString");
            ValidateSettings();
        }

        public LiteDbSettings ProvideSettings()
        {
            return new LiteDbSettings { DataBaseLocation = DbPath };
        }

        private void ValidateSettings()
        {
            if (string.IsNullOrEmpty(DbPath)) {
                throw new ArgumentException("Can not be null or empty", nameof(DbPath));
            }

            if (Directory.Exists(DbPath)) {
                throw new ArgumentException("Path should be valid", nameof(DbPath));
            }
        }
    }
}
