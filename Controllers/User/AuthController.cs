using GIT_KOREA_QA_API.Models.User;
using GIT_KOREA_QA_API.Services.User;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace GIT_KOREA_QA_API.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly IAuthService _authService;

        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //-----------------------------------------------------------------------------
        //
        //  PUBLIC METHODS
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 로그인
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin request)
        {
            var result = await _authService.LoginAsync(request);
            return Ok(result);
        }

        /// <summary>
        /// 토큰 재발급
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("refresh")]
        public IActionResult Refresh([FromBody] UserRefreshToken request)
        {
            var result = _authService.RefreshToken(request.RefreshToken);

            if (result == null)
                return Unauthorized(new { message = "Invalid refresh token" });

            return Ok(result);
        }

        /// <summary>
        /// 토큰 유효성 검사. 이 메서드는 사용자가 보내온 토큰을 기반으로 유효성을 검사하는 것이므로 동기방식으로 동작한다.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("validate")]
        public IActionResult Validate([FromBody] UserActiveToken request)
        {
            var result = new
            {
                result = _authService.ValidateToken(request.Token)
            };

            return Ok(result);
        }
    }
}
