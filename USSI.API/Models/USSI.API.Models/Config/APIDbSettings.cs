using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Models.Config
{
    public class APIDbSettings
    {
        public string DatabaseType { get; set; } = "Sqlite";
        public string ConnectionString { get; set; } = "";
    }
}
