using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GIT_KOREA_QA_API.Entity.Inspection
{
    /// <summary>
    /// 서연이화 검사결과 등록
    /// </summary>
    public class InspectionResult
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SERIAL { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_DATE { get; set; }

        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_DN_DIV { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_FML_DIV { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_TARGET_DIV { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_LOTNO { get; set; }

        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_ID1 { get; set; }

        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_ID2 { get; set; }

        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_ID3 { get; set; }

        /// <summary>
        /// 제품사진명1
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_NM1 { get; set; }

        /// <summary>
        /// 제품사진명2
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_NM2 { get; set; }

        /// <summary>
        /// 제품사진명3
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_IMAGE_NM3 { get; set; }

        /// <summary>
        /// 이상유무
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROBLEM_YN { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MGRT_RESULT { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USER_ID { get; set; }

        /// <summary>
        /// 검사자 사번
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_INSPECT_EMPNO { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_VINCD { get; set; }

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
        /// 품명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_ITEMNM { get; set; }

        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIV { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIV { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        [OracleParameter(OracleDbType.Date, ParameterDirection.Output)]
        public DateTime? INSERT_DATE { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string INSERT_ID { get; set; }

        /// <summary>
        ///  검사자 사번
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 6)]
        public string INSPECT_EMPNO { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string INSTALL_POS { get; set; }

        /// <summary>
        /// 품명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string ITEMNM { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string LINECD { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string MEAS_DATE { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1000)]
        public string MGRT_RESULT { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1)]
        public string PROBLEM_YN { get; set; }

        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_ID1 { get; set; }

        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_ID2 { get; set; }

        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_ID3 { get; set; }

        /// <summary>
        /// 제품사진명1
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_NM1 { get; set; }

        /// <summary>
        /// 제품사진명2
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_NM2 { get; set; }

        /// <summary>
        /// 제품사진명3
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string PROD_IMAGE_NM3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string PROD_LOTNO { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int SERIAL { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string TARGET_DIV { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        [OracleParameter(OracleDbType.Date, ParameterDirection.Output)]
        public DateTime? UPDATE_DATE { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string UPDATE_ID { get; set; }

        /// <summary>
        /// 차종
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string VINCD { get; set; }

        public InspectionResult()
        {
            // 기본값 초기화
            IN_SERIAL = 0;
            IN_MEAS_DATE = string.Empty;
            IN_DN_DIV = string.Empty;
            IN_FML_DIV = string.Empty;
            IN_TARGET_DIV = string.Empty;
            IN_PROD_LOTNO = string.Empty;
            IN_PROD_IMAGE_ID1 = string.Empty;
            IN_PROD_IMAGE_ID2 = string.Empty;
            IN_PROD_IMAGE_ID3 = string.Empty;
            IN_PROD_IMAGE_NM1 = string.Empty;
            IN_PROD_IMAGE_NM2 = string.Empty;
            IN_PROD_IMAGE_NM3 = string.Empty;
            IN_PROBLEM_YN = string.Empty;
            IN_MGRT_RESULT = string.Empty;
            IN_USER_ID = string.Empty;
            IN_INSPECT_EMPNO = string.Empty;
            IN_VINCD = string.Empty;
            IN_LINECD = string.Empty;
            IN_INSTALL_POS = string.Empty;
            IN_ITEMNM = string.Empty;
            DN_DIV = string.Empty;
            FML_DIV = string.Empty;
            INSERT_DATE = DateTime.Now;
            INSERT_ID = string.Empty;
            INSPECT_EMPNO = string.Empty;
            INSTALL_POS = string.Empty;
            ITEMNM = string.Empty;
            LINECD = string.Empty;
            MEAS_DATE = string.Empty;
            MGRT_RESULT = string.Empty;
            PROBLEM_YN = string.Empty;
            PROD_IMAGE_ID1 = string.Empty;
            PROD_IMAGE_ID2 = string.Empty;
            PROD_IMAGE_ID3 = string.Empty;
            PROD_IMAGE_NM1 = string.Empty;
            PROD_IMAGE_NM2 = string.Empty;
            PROD_IMAGE_NM3 = string.Empty;
            PROD_LOTNO = string.Empty;
            SERIAL = 0;
            TARGET_DIV = string.Empty;
            UPDATE_DATE = DateTime.Now;
            UPDATE_ID = string.Empty;
            VINCD = string.Empty;
        }
    }

    /// <summary>
    /// 협력사 검사결과 등록
    /// </summary>
    public class VendorInspectionResult
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Input)]
        public int IN_SERIAL { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MEAS_DATE { get; set; }

        /// <summary>
        /// 관리자이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MANAGER_NM { get; set; }

        /// <summary>
        /// 주야구분(유형코두 : FN)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_DN_DIV { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_FML_DIV { get; set; }

        /// <summary>
        /// 대상구분(유형코드 : FL)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_TARGET_DIV { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROD_LOTNO { get; set; }

        /// <summary>
        /// 제품사진1
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Input)]
        public byte[]? IN_PROD_IMAGE { get; set; }

        /// <summary>
        /// 제품사진2
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Input)]
        public byte[]? IN_PROD_IMAGE2 { get; set; }

        /// <summary>
        /// 제품사진3
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Input)]
        public byte[]? IN_PROD_IMAGE3 { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PROBLEM_YN { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_MGRT_RESULT { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_USER_ID { get; set; }

        /// <summary>
        /// 주야구분(유형코두 : FN)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string DN_DIV { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string FML_DIV { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        [OracleParameter(OracleDbType.Date, ParameterDirection.Output)]
        public DateTime? INSERT_DATE { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string INSERT_ID { get; set; }

        /// <summary>
        /// 관리자이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string MANAGER_NM { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string MEAS_DATE { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1000)]
        public string MGRT_RESULT { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 1)]
        public string PROBLEM_YN { get; set; }

        /// <summary>
        /// 제품사진1
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? PROD_IMAGE { get; set; }

        /// <summary>
        /// 제품사진2
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? PROD_IMAGE2 { get; set; }

        /// <summary>
        /// 제품사진3
        /// </summary>
        [OracleParameter(OracleDbType.Blob, ParameterDirection.Output)]
        public byte[]? PROD_IMAGE3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string PROD_LOTNO { get; set; }

        /// <summary>
        /// 시리얼번호
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int? SERIAL { get; set; }

        /// <summary>
        /// 대상구분(유형코드 : FL)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string TARGET_DIV { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        [OracleParameter(OracleDbType.Date, ParameterDirection.Output)]
        public DateTime? UPDATE_DATE { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string UPDATE_ID { get; set; }

        public VendorInspectionResult()
        {
            // 기본값 초기화
            IN_SERIAL = 0;
            IN_MEAS_DATE = string.Empty;
            IN_MANAGER_NM = string.Empty;
            IN_DN_DIV = string.Empty;
            IN_FML_DIV = string.Empty;
            IN_TARGET_DIV = string.Empty;
            IN_PROD_LOTNO = string.Empty;
            IN_PROD_IMAGE = Array.Empty<byte>();
            IN_PROD_IMAGE2 = Array.Empty<byte>();
            IN_PROD_IMAGE3 = Array.Empty<byte>();
            IN_PROBLEM_YN = string.Empty;
            IN_MGRT_RESULT = string.Empty;
            IN_USER_ID = string.Empty;
            DN_DIV = string.Empty;
            FML_DIV = string.Empty;
            INSERT_DATE = DateTime.Now;
            INSERT_ID = string.Empty;
            MANAGER_NM = string.Empty;
            MEAS_DATE = string.Empty;
            MGRT_RESULT = string.Empty;
            PROBLEM_YN = string.Empty;
            PROD_IMAGE = Array.Empty<byte>();
            PROD_IMAGE2 = Array.Empty<byte>();
            PROD_IMAGE3 = Array.Empty<byte>();
            PROD_LOTNO = string.Empty;
            SERIAL = 0;
            TARGET_DIV = string.Empty;
            UPDATE_DATE = DateTime.Now;
            UPDATE_ID = string.Empty;
        }
    }
}
