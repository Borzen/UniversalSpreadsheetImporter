using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Models.Config
{
    public class APIDbSettings
    {
        public static string ConfigSection = "APIDb";
        public string DatabaseType { get; set; } = "Sqlite";
        public string ConnectionString { get; set; } = "";

        public string SQLFileLocation { get; set; } = "";
    }
}
