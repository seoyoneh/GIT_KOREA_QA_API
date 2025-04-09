using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GIT_KOREA_QA_API.Controllers.Health
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet("check")]
        public IActionResult HealthCheck()
        {
            return Ok(new { message = "Health Check!"});
        }
    }
}
