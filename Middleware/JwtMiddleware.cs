using GIT_KOREA_QA_API.Services.User;
using System.IdentityModel.Tokens.Jwt;

namespace GIT_KOREA_QA_API.Middleware
{
    public class JwtMiddleware
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        //-----------------------------------------------------------------------------
        //
        //  PUBLIC METHODS
        //
        //-----------------------------------------------------------------------------
        public async Task Invoke(HttpContext context, IAuthService authService)
        {
            // 토큰은 Request 헤더의 Authorization 필드에 "Baerer <Token...>" 형식으로 들어온다.
            // 그래서 Headers["Authorization"]로 토큰을 가져온 뒤 띄어쓰기를 기준으로 분리한 뒤 뒤에 있는 값을 가져온다.
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                AttachUserToContext(context, token, authService);

            await _next(context);
        }

        private void AttachUserToContext(HttpContext context, string token, IAuthService authService)
        {
            try
            {
                if (authService.ValidateToken(token))
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwtToken = tokenHandler.ReadJwtToken(token);

                    // 토큰에서 필요한 클레임 값을 추출하여 컨텍스트에 추가
                    var userId = jwtToken.Claims.First(x => x.Type == "userId").Value;
                    var role = jwtToken.Claims.First(x => x.Type == "userRole").Value;

                    // 컨텍스트 항목에 사용자 정보 추가
                    context.Items["UserId"] = userId;
                    context.Items["UserRole"] = role;
                }
            }
            catch
            {
                // 토큰 검증 실패 시 처리하지 않음 (인증 필터에서 처리)
            }
        }

    }
}
