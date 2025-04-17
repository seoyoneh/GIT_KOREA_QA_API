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

        public async Task<Inquery_SeoyonehResult> GetInspection_Seoyoneh(InspectionSeoyoneh_ModelRequest param)
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
                        "SIS.APG_QA_MOBILE.INQUERY_SEOYONEH",
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

        public async Task<Inquery_VendorResult> GetInspection_Vendor(InspectionVendor_ModelRequest param)
        {
            try
            {
                using (var connection = CreateConnection())
                {

                    connection.Open();

                    Inquery_VendorIn model = new Inquery_VendorIn
                    {
                        IN_CORCD = param.Corcd!,
                        IN_BIZCD = param.Bizcd!,
                        IN_MEAS_DATE = param.MeasDate!,
                        IN_USERID = param.UserId!
                    };

                    // 모델을 OracleDynamicParameters로 변환
                    var parameters = model.ToOracleParameters();
                    //parameters.Add("OUT_CURSOR", null, OracleDbType.RefCursor, ParameterDirection.Output);

                    // 저장 프로시저 실행
                    var InspectionInfo = await connection.QueryFirstOrDefaultAsync<Inquery_VendorOut>(
                        "SIS.APG_QA_MOBILE.INQUERY_SEOYONEH",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    );

                    // 출력 파라미터 값을 모델에 매핑

                    if (null != InspectionInfo)
                    {
                        Inquery_VendorResult result = new()
                        {
                            Serial = InspectionInfo.SERIAL ?? string.Empty,
                            Vincd = InspectionInfo.VINCD ?? string.Empty,
                            MeasItem = InspectionInfo.MEAS_ITEMNM ?? string.Empty,
                            JO_CHO = InspectionInfo.JO_CHO ?? string.Empty,
                            JO_JUNG = InspectionInfo.JO_JUNG ?? string.Empty,
                            YA_CHO = InspectionInfo.YA_CHO ?? string.Empty,
                            YA_JUNG = InspectionInfo.YA_JUNG ?? string.Empty,
                        };

                        return result;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("검사 정보 조회 중 오류 발생", ex);
            }
            //throw new NotImplementedException();
        }

        public async Task<Inquery_Seoyoneh_DetailResult> GetInspection_Seoyoneh_Detail(InspectionSeoyonehDetail_ModelRequest param)
        {
            try
            {
                using (var connection = CreateConnection())
                {

                    connection.Open();

                    Inquery_Seoyoneh_DetailIn model = new Inquery_Seoyoneh_DetailIn
                    {
                        IN_SERIAL = param.Serial!,
                        IN_MEAS_DATE = param.MeasDate!,
                        IN_LANG_SET = param.LangSet!
                    };

                    // 모델을 OracleDynamicParameters로 변환
                    var parameters = model.ToOracleParameters();
                    //parameters.Add("OUT_CURSOR", null, OracleDbType.RefCursor, ParameterDirection.Output);

                    // 저장 프로시저 실행
                    var InspectionInfo = await connection.QueryFirstOrDefaultAsync<Inquery_Seoyoneh_DetailOut>(
                        "SIS.APG_QA_MOBILE.INQUERY_SEOYONEH_DETAIL",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    );

                    // 출력 파라미터 값을 모델에 매핑

                    if (null != InspectionInfo)
                    {
                        Inquery_Seoyoneh_DetailResult result = new()
                        {
                            Serial = InspectionInfo.serial ?? string.Empty,
                            MeasDate = InspectionInfo.measDate ?? string.Empty,
                            DnDiv = InspectionInfo.dnDiv ?? string.Empty,
                            DnDivnm = InspectionInfo.dnDivNm ?? string.Empty,
                            FmlDiv = InspectionInfo.fmlDiv ?? string.Empty,
                            FmlDivnm = InspectionInfo.fmlDivNm ?? string.Empty,
                            ProdLotno = InspectionInfo.prodLotNo ?? string.Empty,
                            ProblemYn = InspectionInfo.problemYn ?? string.Empty,
                            MgrtResult = InspectionInfo.mgrtResult ?? string.Empty,
                            Insertnm = InspectionInfo.insertNm ?? string.Empty,
                            Insertdate = InspectionInfo.insertDate ?? string.Empty,
                            Updatenm = InspectionInfo.updateNm ?? string.Empty,
                            Updatedate = InspectionInfo.updateDate ?? string.Empty,
                            ProdImageId1 = InspectionInfo.prodImageId1 ?? string.Empty,
                            ProdImageId2 = InspectionInfo.prodImageId2 ?? string.Empty,
                            ProdImageId3 = InspectionInfo.prodImageId3 ?? string.Empty,
                            StdPhoto = InspectionInfo.stdPhoto ?? string.Empty,
                            PptFileName = InspectionInfo.pptFileName ?? string.Empty,
                            PptFileSize = InspectionInfo.pptFileSize ?? string.Empty,
                            ImgFile = InspectionInfo.imgFile ?? string.Empty,
                            ImgFileName = InspectionInfo.imgFileName ?? string.Empty,
                            ImgFileSize = InspectionInfo.imgFileSize ?? string.Empty,
                            Seq = InspectionInfo.seq,
                        };

                        return result;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("검사 정보 조회 중 오류 발생", ex);
            }

            //throw new NotImplementedException();
        }

        public async Task<Inquery_Vendor_DetailResult> GetInspection_Vendor_Detail(InspectionVendorDetail_ModelRequest param)
        {
            try
            {
                using (var connection = CreateConnection())
                {

                    connection.Open();

                    Inquery_Vendor_DetailIn model = new Inquery_Vendor_DetailIn
                    {
                        IN_SERIAL = param.Serial!,
                        IN_MEAS_DATE = param.MeasDate!,
                        IN_LANG_SET = param.LangSet!
                    };

                    // 모델을 OracleDynamicParameters로 변환
                    var parameters = model.ToOracleParameters();
                    //parameters.Add("OUT_CURSOR", null, OracleDbType.RefCursor, ParameterDirection.Output);

                    // 저장 프로시저 실행
                    var InspectionInfo = await connection.QueryFirstOrDefaultAsync<Inquery_Vendor_DetailOut>(
                        "SIS.APG_QA_MOBILE.INQUERY_VENDOR_DETAIL",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    );

                    // 출력 파라미터 값을 모델에 매핑

                    if (null != InspectionInfo)
                    {
                        Inquery_Vendor_DetailResult result = new()
                        {
                            Serial = InspectionInfo.Serial ?? string.Empty,
                            MeasDate = InspectionInfo.MeasDate ?? string.Empty,
                            Vincd = InspectionInfo.Vincd ?? string.Empty,
                            DnDiv = InspectionInfo.DnDiv ?? string.Empty,
                            DnDivNm = InspectionInfo.DnDivNm ?? string.Empty,
                            FmlDiv = InspectionInfo.FmlDiv ?? string.Empty,
                            FmlDivNm = InspectionInfo.FmlDivNm ?? string.Empty,
                            ProdLotNo = InspectionInfo.ProdLotNo ?? string.Empty,
                            ProblemYn = InspectionInfo.ProblemYn ?? string.Empty,
                            MgrtResult = InspectionInfo.MgrtResult ?? string.Empty,
                            InsertNm = InspectionInfo.InsertNm ?? string.Empty,
                            InsertDate = InspectionInfo.InsertDate ?? string.Empty,
                            UpdateNm = InspectionInfo.UpdateNm ?? string.Empty,
                            UpdateDate = InspectionInfo.UpdateDate ?? string.Empty,
                            ProdImage1 = InspectionInfo.ProdImage1,
                            ProdImage2 = InspectionInfo.ProdImage2,
                            ProdImage3 = InspectionInfo.ProdImage3,
                            StdPhoto = InspectionInfo.StdPhoto,
                            StdPhotoFileId = InspectionInfo.StdPhotoFileId,

                        };

                        return result;
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("검사 정보 조회 중 오류 발생", ex);
            }
            //throw new NotImplementedException();
        }

        public Task<InspectionResult> SaveInspection(InspectionSeoyoneh_ModelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<VendorInspectionResult> SaveInspection(InspectionVendor_ModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
