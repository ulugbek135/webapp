using Microsoft.AspNetCore.Mvc;

namespace WepAppLinux.Controllers
{
    [ApiController]
    [Route("/HC")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok();
        }
    }
}