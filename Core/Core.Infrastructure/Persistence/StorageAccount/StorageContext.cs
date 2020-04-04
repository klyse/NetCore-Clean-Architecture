using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure.Persistence.StorageAccount
{
    public class StorageContext : IStorageContext
    {
        public StorageContext(IConfiguration configuration)
        {

            Settings = new StorageSettings();

            #region Map appsettings.json

            Settings.ConnectionString = configuration
                .GetSection("Azure")
                .GetSection("Storage")
                .GetSection("ConnectionString").Value;

            #endregion

            #region Create StorageAccount

			StorageAccount = CloudStorageAccount.Parse(Settings.ConnectionString);

            #endregion

        }

        public CloudStorageAccount StorageAccount { get; set; }
        public StorageSettings Settings { get; set; }
    }
}
