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
        /// 로그인 ID(UserID)
        /// </summary>
        public required string UserName { get; set; }

        /// <summary>
        /// 로그인 패스워드(UserPwd)
        /// </summary>
        public required string Password { get; set; }
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
