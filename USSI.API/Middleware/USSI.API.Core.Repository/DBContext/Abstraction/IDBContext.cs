using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Core.Repository.DBContext.Abstraction
{
    public interface IDBContext
    {
        public IEnumerable<T> RunQuery<T>(string sql, object queryParams, CommandType? commandType = null);

        public void RunScript(string sql, IDbTransaction transaction, CommandType? commandType = null);

        public void RunScript(string sql, object queryParams, IDbTransaction transaction, CommandType? commandType = null);

    }
}
