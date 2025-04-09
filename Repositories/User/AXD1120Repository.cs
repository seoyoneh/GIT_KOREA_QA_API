using System.Data;
using Dapper;
using GIT_KOREA_QA_API.Models.User;
using Oracle.ManagedDataAccess.Client;

namespace GIT_KOREA_QA_API.Repositories.User
{
    public class AXD1120Repository : IAXD1120Repository
    {
        private readonly string _connectionString;

        public AXD1120Repository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }

        /// <summary>
        /// username(사용자 아이디)로 사용자 정보 조회하기
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task<AXD1120?> GetItemByUsername(string username)
        {
            using (var connection = CreateConnection())
            {
                var query = @"
                    SELECT 
                           UserId
                         , UserPwd
                         , UserName
                         , LineCd
                         , LineName
                         , CorCd
                         , CorName
                         , BizCd
                         , BizName
                         , EmpNo
                         , VendCd
                         , UserDiv
                         , PwdErrCount
                         , PwdValidDate
                      FROM AXD1120
                     WHERE USER_ID = :username";

                var parameters = new { username };

                return await connection.QueryFirstOrDefaultAsync<AXD1120>(query, parameters);
            }
        }
    }
}
