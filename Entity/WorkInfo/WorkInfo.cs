using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GIT_KOREA_QA_API.Entity.WorkInfo
{
    /// <summary>
    /// 서연이화 작업정보 입력
    /// </summary>
    public class WorkInfo
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_BIZCD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_VINCD { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PLANT_DIV { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USE_YN { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_YYYYMM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LANG_SET { get; set; }

        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string BIZCD { get; set; }

        /// <summary>
        /// 시리얼키
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int SERIAL { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string VINCD { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string LINECD { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSTALL_POS { get; set; }

        /// <summary>
        /// 검사자 사번
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 6)]
        public string INSPECT_EMPNO { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1)]
        public string USE_YN { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string REMARK { get; set; }

        /// <summary>
        /// 등록일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string REG_DATE { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string PLANT_DIV { get; set; }

        /// <summary>
        /// 라인코드명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string LINENM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int WIRTE_DATE_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int WIRTE_DATA_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int PROBLEM_DATA_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string WRITE_DATA_COLOR { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROBLEM_DATA_COLOR { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string USERNAME { get; set; }

        public WorkInfo()
        {
            // 기본값 초기화
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_VINCD = string.Empty;
            IN_PLANT_DIV = string.Empty;
            IN_USE_YN = string.Empty;
            IN_YYYYMM = string.Empty;
            IN_LANG_SET = string.Empty;
            CORCD = string.Empty;
            BIZCD = string.Empty;
            SERIAL = 0;
            VINCD = string.Empty;
            LINECD = string.Empty;
            INSTALL_POS = string.Empty;
            INSPECT_EMPNO = string.Empty;
            USE_YN = string.Empty;
            REMARK = string.Empty;
            REG_DATE = string.Empty;
            PLANT_DIV = string.Empty;
            LINENM = string.Empty;
            WIRTE_DATE_CNT = 0;
            WIRTE_DATA_CNT = 0;
            PROBLEM_DATA_CNT = 0;
            WRITE_DATA_COLOR = string.Empty;
            PROBLEM_DATA_COLOR = string.Empty;
            USERNAME = string.Empty;
        }
    }

    /// <summary>
    /// 협력사 작업정보 입력
    /// </summary>
    public class VendorWorkInfo
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_BIZCD { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_VINCD { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_ITEMCD { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_ITEMNM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PLANT_DIV { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USE_YN { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_YYYYMM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LANG_SET { get; set; }

        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string BIZCD { get; set; }

        /// <summary>
        /// 시리얼키
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int SERIAL { get; set; }

        /// <summary>
        /// 시료수(사용안함)
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public string SAMPLE_CNT { get; set; }

        /// <summary>
        /// 측정업체
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string MEASURE_VENDCD { get; set; }

        /// <summary>
        /// SCM등록여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1)]
        public string SCM_REG_YN { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1)]
        public string USE_YN { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string REMARK { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string PLANT_DIV { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string VINCD { get; set; }

        /// <summary>
        /// 품목코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string ITEMCD { get; set; }

        /// <summary>
        /// 품명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string ITEMNM { get; set; }

        /// <summary>
        /// 검사분류코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 6)]
        public string INSPECT_CLASSCD { get; set; }

        /// <summary>
        /// 검사분류명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string INSPECT_CLASSNM { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int WIRTE_DATE_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int WRITE_DATA_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int PROBLEM_DATA_CNT { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROBLEM_DATA_COLOR { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string WRITE_DATA_COLOR { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int ResultCode { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1000)]
        public string ResultMessage { get; set; }

        public VendorWorkInfo()
        {
            // 기본값 초기화
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_VINCD = string.Empty;
            IN_ITEMCD = string.Empty;
            IN_MEAS_ITEMNM = string.Empty;
            IN_PLANT_DIV = string.Empty;
            IN_USE_YN = string.Empty;
            IN_YYYYMM = string.Empty;
            IN_LANG_SET = string.Empty;
            CORCD = string.Empty;
            BIZCD = string.Empty;
            SERIAL = 0;
            SAMPLE_CNT = string.Empty;
            MEASURE_VENDCD = string.Empty;
            SCM_REG_YN = string.Empty;
            USE_YN = string.Empty;
            REMARK = string.Empty;
            PLANT_DIV = string.Empty;
            VINCD = string.Empty;
            ITEMCD = string.Empty;
            ITEMNM = string.Empty;
            INSPECT_CLASSCD = string.Empty;
            INSPECT_CLASSNM = string.Empty;
            WIRTE_DATE_CNT = 0;
            WRITE_DATA_CNT = 0;
            PROBLEM_DATA_CNT = 0;
            PROBLEM_DATA_COLOR = string.Empty;
            WRITE_DATA_COLOR = string.Empty;
            ResultCode = 0;
            ResultMessage = string.Empty;
        }
    }
}
