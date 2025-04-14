using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Services.User
{
    public interface IAuthService
    {
        /// <summary>
        /// 로그인 - 토큰 발급
        /// </summary>
        /// <param name="param">사용자 로그인 아이디</param>
        /// <returns></returns>
        Task<UserToken> LoginAsync(UserLogin param);

        /// <summary>
        /// 토큰 재발급
        /// </summary>
        /// <param name="refreshTken">로그인 때 발급했던 재발급 토큰</param>
        /// <returns></returns>
        UserToken RefreshToken(string refreshTken);

        /// <summary>
        /// 토큰 유효성 검사
        /// </summary>
        /// <param name="token">로그인 때 발급했던 Active Token</param>
        /// <returns></returns>
        bool ValidateToken(string token);
    }
}