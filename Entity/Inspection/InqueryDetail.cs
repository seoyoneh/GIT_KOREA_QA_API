using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Reflection.Metadata;

namespace GIT_KOREA_QA_API.Entity.Inspection
{
    /// <summary>
    /// 서연이화 검사기준서 화면
    /// </summary>
    public class Inquery_SeoyonehResult
    {
        public required string Serial { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public required string Vincd { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string Linecd { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string Linenm { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string JO_JUNG { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_CHO { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string YA_JUNG { get; set; }



        public Inquery_SeoyonehResult()
        {
            Serial = string.Empty;
            Vincd = string.Empty;
            Linecd = string.Empty;
            Linenm = string.Empty;
            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;
        }
    }

    public class Inquery_SeoyonehIn
    {
        ///// <summary>
        ///// 시리얼
        ///// </summary>
        //[OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        //public int IN_SERIAL { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_DATE { get; set; }

        /// <summary>
        /// Lang Set
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_LANG_SET { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_VINCD { get; set; }

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
        /// 사용자아이디
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USERID { get; set; }

        ///// <summary>
        ///// 검사기준서 사진
        ///// </summary>
        //[OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        //public byte[]? PPT_FILE { get; set; }

        public Inquery_SeoyonehIn()
        {
            // 기본값 초기화
            //IN_SERIAL = 0;
            IN_CORCD = string.Empty;
            IN_BIZCD = string.Empty;
            IN_VINCD = string.Empty;
            IN_LANG_SET = string.Empty;
            IN_MEAS_DATE = string.Empty;
            IN_USERID = string.Empty;

            //PPT_FILE = Array.Empty<byte>();
        }
    }

    public class Inquery_SeoyonehOut
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string SERIAL { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string VINCD { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string LINECD { get; set; }

        /// <summary>
        /// 라인명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string LINENM { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_CHO { get; set; }

        /// <summary>
        /// 사용자 구분(T11 : 고객, T12 : 한일이화, T15 : 협력업체, T16:2차협력업체)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string JO_JUNG { get; set; }

        /// <summary>
        /// 인증경로(T4A : AD, T4D : DB)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string YA_CHO { get; set; }

        /// <summary>
        /// 관리자권한(사업장선택)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string? YA_JUNG { get; set; }

        /// <summary>
        /// 사원 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string MEAS_ITEMNM { get; set; }

        /// <summary>
        /// 부서 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIV { get; set; }

        /// <summary>
        /// 부서명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIVNM { get; set; }

        /// <summary>
        /// 고객코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIV { get; set; }

        /// <summary>
        /// 업체코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIVNM { get; set; }

        /// <summary>
        /// 패스워드 오류횟수(DB인증만)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output)]
        public string? PROD_LOTNO { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 2)]
        public string PROBLEM_YN { get; set; }

        /// <summary>
        /// 고객명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string MGRT_RESULT { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSERT_NM { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSERT_DATE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string UPDATE_NM { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string UPDATE_DATE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID1 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID2 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE_ID3 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? STD_PHOTO { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PPT_FILE_NAME { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PPT_FILE_SIZE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE_NAME { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string IMG_FILE_SIZE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output, 100)]
        public int SEQ { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE2 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PROD_IMAGE3 { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string STD_PHOTO_FILEID { get; set; }


        public Inquery_SeoyonehOut()
        {
            // 기본값 초기화
            SERIAL = string.Empty;
            VINCD = string.Empty;
            LINECD = string.Empty;
            LINENM = string.Empty;
            JO_CHO = string.Empty;
            JO_JUNG = string.Empty;
            YA_CHO = string.Empty;
            YA_JUNG = string.Empty;
            MEAS_ITEMNM = string.Empty;
            DN_DIV = string.Empty;
            DN_DIVNM = string.Empty;
            FML_DIV = string.Empty;
            FML_DIVNM = string.Empty;
            PROD_LOTNO = string.Empty;
            PROBLEM_YN = string.Empty;
            MGRT_RESULT = string.Empty;
            INSERT_NM = string.Empty;
            INSERT_DATE = string.Empty;
            UPDATE_NM = string.Empty;
            UPDATE_DATE = string.Empty;
            PROD_IMAGE_ID1 = string.Empty;
            PROD_IMAGE_ID2 = string.Empty;
            PROD_IMAGE_ID3 = string.Empty;
            STD_PHOTO = Array.Empty<byte>();
            PPT_FILE_NAME = string.Empty;
            PPT_FILE_SIZE = string.Empty;
            IMG_FILE = string.Empty;
            IMG_FILE_NAME = string.Empty;
            IMG_FILE_SIZE = string.Empty;
            SEQ = 0;
            PROD_IMAGE = string.Empty;
            PROD_IMAGE2 = string.Empty;
            PROD_IMAGE3 = string.Empty;
            STD_PHOTO_FILEID = string.Empty;
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
