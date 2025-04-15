using GIT_KOREA_QA_API.Entity.User;
using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Repositories.User
{
    public interface ILoginRepository
    {
          /// <summary>
        /// 직원 정보 가져오기
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<LoginResult?> GetItemByLogin(UserLogin param);
    }
}
