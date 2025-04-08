using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Repositories.User
{
    public interface IAXD1120Repository
    {
        /// <summary>
        /// 사용자 정보 userId로 조회하기
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<AXD1120?> GetItemByUserId(AXD1120 userInfo);
    }
}
