using Microsoft.AspNetCore.Mvc;
using USSI.API.Core.DataServices.Interfaces;
using USSI.API.Core.DataServices.Interfaces.BaseInterfaces;

namespace USSI.API.Controllers.Admin
{
    [ApiController]
    [Route("admin/db/update")]
    public class DbUpdate : ControllerBase
    {
        private IDBMigrationRunner _runner;

        public DbUpdate(IDBMigrationRunner runner)
        {
            _runner = runner;
        }

        [HttpPost]
        public IActionResult Post()
        {
            _runner.RunUpdate();
            return Ok();
        }
    }
}
