using GIT_KOREA_QA_API.Exceptions;
using GIT_KOREA_QA_API.Models.User;
using GIT_KOREA_QA_API.Repositories.User;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GIT_KOREA_QA_API.Services.User
{
    public class AuthService : IAuthService
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly IAXD1120Repository _userRepository;
        private readonly IConfiguration _configuration;

        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public AuthService(IAXD1120Repository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        //-----------------------------------------------------------------------------
        //
        //  IMPLEMENTATIONS
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 로그인 처리(JWT 토큰 발급)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>JWT객체</returns>
        /// <exception cref="ApiException"></exception>
        public async Task<UserToken> LoginAsync(string username, string password)
        {


            AXD1120? item = await _userRepository.GetItemByUsername(username);

            // ID가 틀려서 조회가 안되거나,
            // Password 필드가 null이거나,
            // Password 필드가 전달받은 password와 값이 다른경우
            if (item == null || item.UserPwd == null || (
                item.UserPwd != null &&
                !item.UserPwd.Equals(password)
              )
            )
            {
                if (item != null &&
                   item.UserPwd != null &&
                !item.UserPwd.Equals(password)) // 사용자 정보는 조회되었지만 패스워드가 서로 다를 경우
                {
                    /// TODO : 사용자 PwdErrCount 값을 하나 늘리는 작업을 수행해야함
                }

                throw new ApiException(StatusCodes.Status404NotFound, "사용자를 찾을 수 없습니다.");
            }
            else
            {
                var result = new UserToken
                {
                    ActiveToken = GenerateAccessToken(item),
                    RefreshToken = GenerateRefreshToken(item),
                    ExpiresAt = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:DurationInMinutes"]!))
                };

                return result;
            }
        }

        /// <summary>
        /// 토큰객체 재 생성
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        public async Task<UserToken> RefreshTokenAsync(string refreshToken)
        {
            if(!ValidateToken(refreshToken))
            {
                throw new ApiException(StatusCodes.Status401Unauthorized, "사용자 세션이 더 이상 유효하지 않습니다.");
            }

            AXD1120? item = await _userRepository.GetItemByUsername(ReadToken(refreshToken, "userId")!);

            if(item == null)
            {
                throw new ApiException(StatusCodes.Status404NotFound, "사용자를 찾을 수 없습니다.");
            }

            var result = new UserToken
            {
                ActiveToken = GenerateAccessToken(item),
                RefreshToken = GenerateRefreshToken(item),
                ExpiresAt = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:DurationInMinutes"]!))
            };

            return result;
        }

        public bool ValidateToken(string token)
        {
            return ValidateJwtToken(token);
        }

        //-----------------------------------------------------------------------------
        //
        //  PRIVATE METHODS
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 토큰 생성
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private string GenerateAccessToken(AXD1120 user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("userId", user.UserId), // 사용자 ID
                    new Claim("userRole", user.UserDiv), // 사용자 구분
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:DurationInMinutes"]!)),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GenerateRefreshToken(AXD1120 user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("userId", user.UserId),
                    new Claim("userRole", user.UserDiv),
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:RefreshDurationMinutes"]!)),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// 토큰(ActiveToken or Refresh Token)이 유효한지 확인하는 메서드
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        private bool ValidateJwtToken(string param)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                // 서명 키 설정 (토큰 생성시 사용한 것과 동일한 키를 사용해야 함)
                var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);

                // 토큰 검증 매개변수 설정
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,    // 서명 키 검증
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,              // 발급자 검증
                    ValidIssuer = _configuration["Jwt:Issuer"],         // 발급자 이름 (토큰 생성시 설정한 값)
                    ValidateAudience = true,            // 수신자 검증
                    ValidAudience = _configuration["Jwt:Audience"],     // 수신자 이름 (토큰 생성시 설정한 값)
                    ValidateLifetime = true,            // 만료시간 검증
                    ClockSkew = TimeSpan.Zero           // 시간 오차 허용 범위
                };

                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(param, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch (SecurityTokenExpiredException)
            {
                throw new ApiException(StatusCodes.Status401Unauthorized, "로그인 세션이 만료되었습니다.");
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                throw new ApiException(StatusCodes.Status401Unauthorized, "로그인 세션 서명이 유효하지 않습니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"토큰 검증 오류: {ex.Message}");
                throw new ApiException(StatusCodes.Status401Unauthorized, "로그인 정보에 이상이 있습니다.");
            }
        }

        private string? ReadToken(string token, string key)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);

            var claim = jwtToken.Claims.FirstOrDefault(c => c.Type == key);

            return claim?.Value;
        }
    }
}
