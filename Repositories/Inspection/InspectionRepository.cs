using System.Data;
using GIT_KOREA_QA_API.Entity.Inspection;
using GIT_KOREA_QA_API.Models.Inspection;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using GIT_KOREA_QA_API.Helper.Database;
using GIT_KOREA_QA_API.Entity.User;

namespace GIT_KOREA_QA_API.Repositories.Inspection
{
    public class InspectionRepository : IInspectionRepository
    {
        private readonly string _connectionString;

        public InspectionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleConnection")!;
        }

        private IDbConnection CreateConnection()
        {
            return new OracleConnection(_connectionString);
        }

        public async Task<Inquery_SeoyonehResult> GetInspection(InspectionModelRequest param)
        {
            try
            {
                using (var connection = CreateConnection())
                {

                    connection.Open();

                    Inquery_SeoyonehIn model = new Inquery_SeoyonehIn
                    {
                        IN_CORCD = param.Corcd!,
                        IN_BIZCD = param.Bizcd!,
                        IN_VINCD = param.Vincd!,
                        IN_LANG_SET = param.LangSet!,
                        IN_MEAS_DATE = param.MeasDate!,
                        IN_USERID = param.UserId!
                    };

                    // 모델을 OracleDynamicParameters로 변환
                    var parameters = model.ToOracleParameters();
                    //parameters.Add("OUT_CURSOR", null, OracleDbType.RefCursor, ParameterDirection.Output);

                    // 저장 프로시저 실행
                    var InspectionInfo = await connection.QueryFirstOrDefaultAsync<Inquery_SeoyonehOut>(
                        "SIS.APG_QA_MOBLIE.INQUERY_SEOYONEH",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    );

                    // 출력 파라미터 값을 모델에 매핑

                    if (null != InspectionInfo)
                    {
                        Inquery_SeoyonehResult result = new()
                        {
                            Serial = InspectionInfo.SERIAL ?? string.Empty,
                            Vincd = InspectionInfo.VINCD ?? string.Empty,
                            Linecd = InspectionInfo.LINECD ?? string.Empty,
                            Linenm = InspectionInfo.LINENM ?? string.Empty,
                            JO_CHO = InspectionInfo.JO_CHO ?? string.Empty,
                            JO_JUNG = InspectionInfo.JO_JUNG ?? string.Empty,
                            YA_CHO= InspectionInfo.YA_CHO ?? string.Empty,
                            YA_JUNG = InspectionInfo.YA_JUNG ?? string.Empty,
                        };

                        return result;
                    }

                    return null;
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("검사 정보 조회 중 오류 발생", ex);
            }

            //throw new NotImplementedException();
        }

        public Task<VendorInspectionResult> GetVendor(VendorInspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<InspectionResult> SaveInspection(InspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<VendorInspectionResult> SaveInspection(VendorInspectionModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
