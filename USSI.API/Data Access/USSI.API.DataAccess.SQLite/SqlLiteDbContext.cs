using Dapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Core.Repository.DBContext.Abstraction;
using USSI.API.Models.Config;

namespace USSI.API.DataAccess.SQLite
{
    internal class SqlLiteDbContext : IDBContext
    {
        private readonly SqliteConnection _connection;
        public SqlLiteDbContext(IOptions<APIDbSettings> apiSettings)
        {
            _connection = new SqliteConnection("Data Source=" + apiSettings.Value.SQLFileLocation);
        }

        public IEnumerable<T> RunQuery<T>(string sql, object queryParams, CommandType? commandType = null)
        {
            return _connection.Query<T>(sql, queryParams, commandType: commandType);
        }

        public void RunScript(string sql, IDbTransaction transaction, CommandType? commandType = null)
        {
            try
            {
                _connection.Execute(sql, transaction: transaction, commandType: commandType);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void RunScript(string sql, object queryParams, IDbTransaction transaction, CommandType? commandType = null)
        {
            try
            {
                _connection.Execute(sql, queryParams, transaction: transaction, commandType: commandType);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
