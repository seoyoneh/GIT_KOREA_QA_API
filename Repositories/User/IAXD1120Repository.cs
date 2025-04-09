using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Repositories.User
{
    public interface IAXD1120Repository
    {
        /// <summary>
        /// 사용자 정보 사용자 아이디로 조회하기<br />
        /// 사실 사용자 아이디가 PK임 그래서 GetItemByUserId 라고 해도 무방함
        /// </summary>
        /// <param name="username">사용자 아이디</param>
        /// <returns></returns>
        Task<AXD1120?> GetItemByUsername(string username);
    }
}
