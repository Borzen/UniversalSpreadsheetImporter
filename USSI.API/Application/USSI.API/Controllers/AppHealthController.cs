using Microsoft.AspNetCore.Mvc;

namespace USSI.API.Controllers
{
    [ApiController]
    [Route("")]
    public class AppHealthController : ControllerBase
    {
        private readonly ILogger<AppHealthController> _logger;

        public AppHealthController(ILogger<AppHealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Ping")]
        public IActionResult Get()
        {
            return Ok(DateTime.UtcNow);
        }
    }
}
