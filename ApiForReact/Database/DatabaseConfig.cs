using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace ApiForReact.Database
{
    public class DatabaseConfig
    {

        public static string GetConnection()
        {
            var config = GetConfig();
            return config.GetSection("ConnectionString").GetSection("DefaultConnection").Value;
        }

        private static IConfigurationRoot GetConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
