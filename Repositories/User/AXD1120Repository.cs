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

        public async Task<AXD1120?> GetItemByUserId(AXD1120 userInfo)
        {
            using (var connection = CreateConnection())
            {
                var query = @"
                  SELECT *
                    FROM AXD1120
                   WHERE USER_ID = :UserId";
                
                var parameters = new { userInfo.UserId };

                return await connection.QueryFirstOrDefaultAsync<AXD1120>(query, parameters);
            }
        }
    }
}
