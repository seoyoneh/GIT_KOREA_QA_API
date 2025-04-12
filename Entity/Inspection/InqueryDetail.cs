using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GIT_KOREA_QA_API.Entity.Inspection
{
    /// <summary>
    /// 서연이화 검사기준서 화면
    /// </summary>
    public class InqueryDetail
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SERIAL { get; set; }

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
        /// TODO : 주석필요
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SEQ { get; set; }

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
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LINECD { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_INSTALL_POS { get; set; }

        /// <summary>
        /// 검사기준서 사진
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? PPT_FILE { get; set; }

        public InqueryDetail()
        {
            // 기본값 초기화
            IN_SERIAL = 0;
            IN_YYYYMM = string.Empty;
            IN_LANG_SET = string.Empty;
            IN_SEQ = 0;
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_LINECD = string.Empty;
            IN_INSTALL_POS = string.Empty;
            PPT_FILE = Array.Empty<byte>();
        }
    }

    /// <summary>
    /// 협력사 검사기준서 화면
    /// </summary>
    public class VendorInqueryDetail
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SERIAL { get; set; }

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
        /// 검사기준서 사진
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? INSPECT_STD_PHOTO { get; set; }

        public VendorInqueryDetail()
        {
            // 기본값 초기화
            IN_SERIAL = 0;
            IN_YYYYMM = string.Empty;
            IN_LANG_SET = string.Empty;
            INSPECT_STD_PHOTO = Array.Empty<byte>();
        }
}
}
