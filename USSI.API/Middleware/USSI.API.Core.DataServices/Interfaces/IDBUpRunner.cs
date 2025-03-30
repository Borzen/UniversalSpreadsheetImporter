using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSI.API.Core.DataServices.Interfaces.BaseInterfaces;

namespace USSI.API.Core.DataServices.Interfaces
{
    public interface IDBUpRunner : IDBMigrationRunner
    {
        int RunDBUpRunner();

        int IDBMigrationRunner.RunInit() { return RunDBUpRunner(); }
        int IDBMigrationRunner.RunUpdate() { return RunDBUpRunner(); }

    }
}
