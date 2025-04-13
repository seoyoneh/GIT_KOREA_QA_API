using Microsoft.AspNetCore.Mvc;

namespace GIT_KOREA_QA_API.Controllers.Health
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// API 서버가 살아있는지 확인하는 API
        /// </summary>
        /// <returns></returns>
        [HttpGet("check")]
        public IActionResult HealthCheck()
        {
            return Ok(new { message = "Health Check!"});
        }
    }
}
