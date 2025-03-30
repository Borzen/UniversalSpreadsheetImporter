using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USSI.API.Core.DataServices.Interfaces.BaseInterfaces
{
    public interface IDBMigrationRunner
    {
        public int RunInit();
        public int RunUpdate();
    }
}
