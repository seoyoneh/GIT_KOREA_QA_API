using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Services.User
{
    public interface IAuthService
    {
        /// <summary>
        /// �α��� - ��ū �߱�
        /// </summary>
        /// <param name="param">����� �α��� ���̵�</param>
        /// <returns></returns>
        Task<UserToken> LoginAsync(UserLogin param);

        /// <summary>
        /// ��ū ��߱�
        /// </summary>
        /// <param name="refreshTken">�α��� �� �߱��ߴ� ��߱� ��ū</param>
        /// <returns></returns>
        UserToken RefreshToken(string refreshTken);

        /// <summary>
        /// ��ū ��ȿ�� �˻�
        /// </summary>
        /// <param name="token">�α��� �� �߱��ߴ� Active Token</param>
        /// <returns></returns>
        bool ValidateToken(string token);
    }
}