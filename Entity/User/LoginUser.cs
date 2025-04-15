using GIT_KOREA_QA_API.Helper.Database;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;

namespace GIT_KOREA_QA_API.Entity.User
{
    public class LoginResult
    {
        /// <summary>
        /// 사용자 식별코드(서연이화 : 사원번호, 협력사 : 사용자 ID)
        /// </summary>
        public required string UserId { get; set; }
        /// <summary>
        /// 이름
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// 권한
        /// </summary>
        public required string Role { get; set; }

        public LoginResult()
        {
            UserId = string.Empty;
            Name = string.Empty;
            Role = string.Empty;
        }
    }

    public class EmployeeLogin
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_CORCD { get; set; }

        /// <summary>
        /// 사원번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 6)]
        public string IN_EMPNO { get; set; }

        /// <summary>
        /// 로그인 사용자 비밀번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input, 100)]
        public string IN_PASSWORD { get; set; }

        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Char, ParameterDirection.Output, 4)]
        public string CORCD { get; set; }

        /// <summary>
        /// 사업자코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 4)]
        public string BIZCD { get; set; }

        /// <summary>
        /// 사업장명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 50)]
        public string BIZNM { get; set; }

        /// <summary>
        /// 실코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 8)]
        public string TEAMCD { get; set; }

        /// <summary>
        /// 실명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string TEAMNM { get; set; }

        /// <summary>
        /// 팀코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 8)]
        public string PARTCD { get; set; }

        /// <summary>
        /// 팀명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string PARTNM { get; set; }

        /// <summary>
        /// 언어
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string LANG_SET { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 8)]
        public string LINECD { get; set; }

        /// <summary>
        /// 라인명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string LINENM { get; set; }

        /// <summary>
        /// 부서코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 8)]
        public string DEPTCD { get; set; }

        /// <summary>
        /// 부서명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string DEPTNM { get; set; }

        /// <summary>
        /// 사원번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 6)]
        public string EMPNO { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 20)]
        public string EMPNM { get; set; }

        /// <summary>
        /// 직군코드
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int? WAGES_TYPE { get; set; }

        /// <summary>
        /// 직군명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string WAGES_TYPENM { get; set; }

        /// <summary>
        /// 직책코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 4)]
        public string RESP_WORKCD { get; set; }

        /// <summary>
        /// 직책명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 30)]
        public string RESP_WORKNM { get; set; }

        /// <summary>
        /// 직위코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 4)]
        public string TITLECD { get; set; }

        /// <summary>
        /// 직위명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 40)]
        public string TITLENM { get; set; }

        /// <summary>
        /// 핸드폰번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string MOB_PHONE_NO { get; set; }

        /// <summary>
        /// 생일
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 8)]
        public string BIRTHDAY { get; set; }

        /// <summary>
        /// 그룹웨어 계정 사용여부
        /// </summary>
        [OracleParameter(OracleDbType.Char, ParameterDirection.Output, 1)]
        public string GW_USE_YN { get; set; }
        public EmployeeLogin()
        {
            // 기본값 초기화
            IN_CORCD = string.Empty;
            IN_EMPNO = string.Empty;
            IN_PASSWORD = string.Empty;
            CORCD = string.Empty;
            BIZCD = string.Empty;
            BIZNM = string.Empty;
            TEAMCD = string.Empty;
            TEAMNM = string.Empty;
            PARTCD = string.Empty;
            PARTNM = string.Empty;
            LANG_SET = string.Empty;
            LINECD = string.Empty;
            LINENM = string.Empty;
            DEPTCD = string.Empty;
            DEPTNM = string.Empty;
            EMPNO = string.Empty;
            EMPNM = string.Empty;
            WAGES_TYPE = 0;
            WAGES_TYPENM = string.Empty;
            RESP_WORKCD = string.Empty;
            RESP_WORKNM = string.Empty;
            TITLECD = string.Empty;
            TITLENM = string.Empty;
            MOB_PHONE_NO = string.Empty;
            BIRTHDAY = string.Empty;
            GW_USE_YN = string.Empty;
        }
    }

    public class VendorLoginIn
    {
        /// <summary>
        /// 사용자 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_USER_ID { get; set; }

        /// <summary>
        /// 사원번호(패스워드)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_PASSWORD { get; set; }

        /// <summary>
        /// 사용자 IP
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_USER_IP { get; set; }

        /// <summary>
        /// 사용자 IP
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_LANG_SET { get; set; }

        [OracleParameter(OracleDbType.RefCursor, ParameterDirection.Output)]
        public OracleRefCursor? OUT_CURSOR { get; set; }

        public VendorLoginIn()
        {
            // 기본값 초기화
            IN_USER_ID = string.Empty;
            IN_PASSWORD = string.Empty;
            IN_USER_IP = string.Empty;
            IN_LANG_SET = "KO";
            OUT_CURSOR = null;
        }
    }

    public class VendorLoginOut
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        [OracleParameter(OracleDbType.Char, ParameterDirection.Output, 4)]
        public string CORCD { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 4)]
        public string BIZCD { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string USERID { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string USERNAME { get; set; }

        /// <summary>
        /// 사용자 구분(T11 : 고객, T12 : 한일이화, T15 : 협력업체, T16:2차협력업체)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string USER_DIV { get; set; }

        /// <summary>
        /// 인증경로(T4A : AD, T4D : DB)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 9)]
        public string CERT_COURSE { get; set; }

        /// <summary>
        /// 관리자권한(사업장선택)
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int? ADMIN_FLAG { get; set; }

        /// <summary>
        /// 사원 번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string EMPNO { get; set; }

        /// <summary>
        /// 부서 코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string LINECD { get; set; }

        /// <summary>
        /// 부서명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 200)]
        public string LINENAME { get; set; }

        /// <summary>
        /// 고객코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string CUSTCD { get; set; }

        /// <summary>
        /// 업체코드
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 10)]
        public string VENDCD { get; set; }

        /// <summary>
        /// 패스워드 오류횟수(DB인증만)
        /// </summary>
        [OracleParameter(OracleDbType.Int32, ParameterDirection.Output)]
        public int? PWD_ERR_COUNT { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string USERPWD { get; set; }

        /// <summary>
        /// 고객명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string CUSTNM { get; set; }

        /// <summary>
        /// 업체명
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Output, 100)]
        public string VENDNM { get; set; }

        public VendorLoginOut()
        {
            // 기본값 초기화
            CORCD = string.Empty;
            BIZCD = string.Empty;
            USERID = string.Empty;
            USERNAME = string.Empty;
            USER_DIV = string.Empty;
            CERT_COURSE = string.Empty;
            ADMIN_FLAG = 0;
            EMPNO = string.Empty;
            LINECD = string.Empty;
            LINENAME = string.Empty;
            CUSTCD = string.Empty;
            VENDCD = string.Empty;
            PWD_ERR_COUNT = 0;
            USERPWD = string.Empty;
            CUSTNM = string.Empty;
            VENDNM = string.Empty;
        }
    }

    public class LoginRequestIn
    {
        /// <summary>
        /// 사용자 ID
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_USER_ID { get; set; }

        /// <summary>
        /// 사원번호(패스워드)
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_PASSWORD { get; set; }

        /// <summary>
        /// 사용자 IP
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_USER_IP { get; set; }

        /// <summary>
        /// 사용자 IP
        /// </summary>
        [OracleParameter(OracleDbType.Varchar2, ParameterDirection.Input)]
        public string IN_LANG_SET { get; set; }

        [OracleParameter(OracleDbType.RefCursor, ParameterDirection.Output)]
        public OracleRefCursor? OUT_CURSOR { get; set; }

        public VendorLoginIn()
        {
            // 기본값 초기화
            IN_USER_ID = string.Empty;
            IN_PASSWORD = string.Empty;
            IN_USER_IP = string.Empty;
            IN_LANG_SET = "KO";
            OUT_CURSOR = null;
        }
    }

    public class LoginRequestOut
    {

    }
}
