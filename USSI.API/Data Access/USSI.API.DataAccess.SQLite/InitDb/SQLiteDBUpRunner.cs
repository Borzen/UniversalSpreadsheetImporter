using DbUp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Core.DataServices.Abstractions;

namespace USSI.API.DataAccess.SQLite.InitDb
{
    public class SQLiteDBUpRunner : DBUpRunner
    {
        private readonly ILogger<SQLiteDBUpRunner> _logger;
        public SQLiteDBUpRunner(string connectionString, ILogger<SQLiteDBUpRunner> logger) : base(string.IsNullOrEmpty(connectionString) ? ".\\USSI.API.db" : connectionString) 
        { 
            _logger = logger;
        }

        public override int RunDBUpRunner()
        {

            EnsureDatabase.For.SqlDatabase(_connectionString);
            var upgrader = DeployChanges.To.SqliteDatabase(_connectionString)
                .WithScriptsFromFileSystem(".\\SQLFiles")
                .LogTo(_logger)
                .Build();
            
            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                _logger.LogError("Error initing Db");
                return -1;
            }

            _logger.LogInformation("Upgraded Db");
            return 0;
        }
    }
}
