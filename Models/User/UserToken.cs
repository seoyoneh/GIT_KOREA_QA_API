using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GIT_KOREA_QA_API.Models.User
{
    /// <summary>
    /// 사용자 토큰 객체
    /// </summary>
    public class UserToken
    {
        /// <summary>
        /// 사용자 토큰
        /// </summary>
        public required string ActiveToken { get; set; }

        /// <summary>
        /// 리프레쉬 토큰
        /// </summary>
        public required string RefreshToken { get; set; }

        /// <summary>
        /// 만료시간
        /// </summary>
        public required DateTime ExpiresAt { get; set; }
    }

    public class UserLogin
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        public string? CorCd { get; set; }

        /// <summary>
        /// 로그인 ID(UserID)
        /// </summary>
        /// <example>1001000</example>
        public required string Username { get; set; }

        /// <summary>
        /// 로그인 패스워드(UserPwd)
        /// </summary>
        /// <example>0000</example>
        public required string Password { get; set; }

        /// <summary>
        /// 사용자 IP
        /// </summary>
        public string? UserIP { get; set; }

        /// <summary>
        /// 언어
        /// </summary>
        /// <example>KO</example>
        public required string LangSet { get; set; }
    }

    public class UserRefreshToken
    {
        /// <summary>
        /// 재생성 토큰
        /// </summary>
        public required string RefreshToken { get; set; }
    }

    public class UserActiveToken
    {
        /// <summary>
        /// 사용자 토큰
        /// </summary>
        public required string Token { get; set; }
    }
}
