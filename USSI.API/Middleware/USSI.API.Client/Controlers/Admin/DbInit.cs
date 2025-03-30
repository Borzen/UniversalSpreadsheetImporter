using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Client.Interfaces.Controllers.Admin;
using USSI.API.Core.DataServices.Interfaces.BaseInterfaces;

namespace USSI.API.Client.Controlers.Admin
{
    public class DbInit : IDbInit
    {
        private readonly IDBMigrationRunner _runner;
        public DbInit(IDBMigrationRunner runner)
        {
            _runner = runner;
        }

        public int InitDb()
        {
            throw new NotImplementedException();
        }
    }
}
