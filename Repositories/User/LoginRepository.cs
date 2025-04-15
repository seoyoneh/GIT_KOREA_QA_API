using System.Data;
using System.Reflection;
using System.Transactions;
using Dapper;
using GIT_KOREA_QA_API.Entity.User;
using GIT_KOREA_QA_API.Helper.Database;
using GIT_KOREA_QA_API.Models.User;
using Oracle.ManagedDataAccess.Client;

namespace GIT_KOREA_QA_API.Repositories.User
{
    public class LoginRepository : ILoginRepository
    {
        //-----------------------------------------------------------------------------
        //
        // CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly string _connectionString;

        //-----------------------------------------------------------------------------
        //
        // CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public LoginRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleConnection")!;
        }

        //-----------------------------------------------------------------------------
        //
        // IMPLEMENTATION
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 서연이화 로그인
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<LoginResult?> GetItemBySeoyonLogin(UserLogin param)
        {
            using var connection = CreateConnection();
            connection.Open();

            EmployeeLogin model = new EmployeeLogin
            {
                IN_CORCD = param.CorCd!,
                IN_EMPNO = param.UserName,
                IN_REG_EMPNO = param.Password
            };

            // 모델을 OracleDynamicParameters로 변환
            var parameters = model.ToOracleParameters();

            // 저장 프로시저 실행
            await connection.ExecuteAsync(
                "SYSADM.PKG_HR47042.HR47040P",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            // 출력 파라미터 값을 모델에 매핑
            parameters.MapOracleOutputs(model);

            LoginResult result = new ()
            {
                UserId = parameters.Get<string>("EMPNO")!,
                Name = parameters.Get<string>("EMPNAME")!,
                Role = "T12"
            };

            return result;
        }

        /// <summary>
        /// 협력사 로그인
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<LoginResult?> GetItemByVendorLogin(UserLogin param)
        {
            using (var connection = CreateConnection())
            {

                connection.Open();

                VendorLogin model = new VendorLogin
                {
                    IN_USER_ID = param.UserName,
                    IN_PASSWORD = param.Password,
                    IN_USER_IP = param.UserIP!
                };

                // 모델을 OracleDynamicParameters로 변환
                var parameters = model.ToOracleParameters();

                // 저장 프로시저 실행
                await connection.ExecuteAsync(
                    "SYSHANIL.PKG_EPSERVICE.EXECUTE_LOGIN",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                // 출력 파라미터 값을 모델에 매핑
                parameters.MapOracleOutputs(model);

                LoginResult result = new ()
                {
                    UserId = parameters.Get<string>("USERID")!,
                    Name = parameters.Get<string>("USERNAME")!,
                    Role = parameters.Get<string>("USER_DIV")!,
                };

                return result;
            }
        }

        //-----------------------------------------------------------------------------
        //
        // PRIVATE METHODS
        //
        //-----------------------------------------------------------------------------
        private IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }
    }
}
