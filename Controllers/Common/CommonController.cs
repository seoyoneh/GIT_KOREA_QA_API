using Microsoft.AspNetCore.Mvc;

namespace GIT_KOREA_QA_API.Controllers.Common
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {
        [HttpGet("today")]
        /// <summary>
        /// 오늘 날짜 가져오기
        /// </summary>
        /// <returns></returns>
        public IActionResult GetToday()
        {
            return Ok(new
            {
                today = DateTime.Now.ToString("yyyy-MM-dd")
            });
        }
    }
}
