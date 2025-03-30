using Microsoft.AspNetCore.Mvc;
using USSI.API.Client.Interfaces.Controllers.Admin;
using USSI.API.Core.DataServices.Interfaces.BaseInterfaces;

namespace USSI.API.Controllers.Admin
{
    [ApiController]
    [Route("admin/db/init")]
    public class InitConfigDb : ControllerBase
    {
        private IDbInit _dbInit;
        public InitConfigDb(IDbInit dbInit)
        {
            _dbInit = dbInit;
        }
        [HttpPost]
        public IActionResult Post()
        {
            _dbInit.InitDb();
            return Ok();
        }
    }
}
