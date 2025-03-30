using Microsoft.AspNetCore.Mvc;
using USSI.API.Core.DataServices.Interfaces.BaseInterfaces;

namespace USSI.API.Controllers.Admin
{
    [ApiController]
    [Route("admin/db/init")]
    public class InitConfigDb : ControllerBase
    {
        private IDBMigrationRunner _runner;
        public InitConfigDb(IDBMigrationRunner runner)
        {
            _runner = runner;
        }
        [HttpPost]
        public IActionResult Post()
        {
            _runner.RunInit();
            return Ok();
        }
    }
}
