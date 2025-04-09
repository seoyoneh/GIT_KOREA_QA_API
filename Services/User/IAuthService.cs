using GIT_KOREA_QA_API.Models.User;

namespace GIT_KOREA_QA_API.Services.User
{
    public interface IAuthService
    {
        /// <summary>
        /// �α��� - ��ū �߱�
        /// </summary>
        /// <param name="username">����� �α��� ���̵�</param>
        /// <param name="password">����� �α��� �н�����</param>
        /// <returns></returns>
        Task<UserToken> LoginAsync(string username, string password);

        /// <summary>
        /// ��ū ��߱�
        /// </summary>
        /// <param name="refreshTken">�α��� �� �߱��ߴ� ��߱� ��ū</param>
        /// <returns></returns>
        Task<UserToken> RefreshTokenAsync(string refreshTken);

        /// <summary>
        /// ��ū ��ȿ�� �˻�
        /// </summary>
        /// <param name="token">�α��� �� �߱��ߴ� Active Token</param>
        /// <returns></returns>
        bool ValidateToken(string token);
    }
}