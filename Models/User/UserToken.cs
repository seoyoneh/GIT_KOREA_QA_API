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
        public required string ActiveToken;

        /// <summary>
        /// 리프레쉬 토큰
        /// </summary>
        public required string RefreshToken;

        /// <summary>
        /// 만료시간
        /// </summary>
        public required DateTime expiresAt;
    }
}
