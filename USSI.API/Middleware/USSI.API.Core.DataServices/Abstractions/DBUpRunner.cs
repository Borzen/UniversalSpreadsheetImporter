using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Core.DataServices.Interfaces;

namespace USSI.API.Core.DataServices.Abstractions
{
    public abstract class DBUpRunner : IDBUpRunner
    {
        public readonly string _connectionString;
        public DBUpRunner(string connectionString)
        {
            _connectionString = connectionString;
        }

        public abstract int RunDBUpRunner();
    }
}
