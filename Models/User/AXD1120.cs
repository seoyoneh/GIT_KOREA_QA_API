namespace GIT_KOREA_QA_API.Models.User
{
    /// <summary>
    /// 사용자 관리 테이블 (User)
    /// </summary>
    public class AXD1120
    {
        /// <summary>
        /// 사용자 ID
        /// </summary>
        public required string UserId { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>
        public string? UserPwd { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// 전자메일 주소
        /// </summary>
        public string? EmailAddr { get; set; }

        /// <summary>
        /// 부서 코드
        /// </summary>
        public string? LineCd { get; set; }

        /// <summary>
        /// 부서명
        /// </summary>
        public string? LineName { get; set; }

        /// <summary>
        /// 법인 코드
        /// </summary>
        public string? CorCd { get; set; }

        /// <summary>
        /// 법인코드명
        /// </summary>
        public string? CorName { get; set; }

        /// <summary>
        /// 시스템 코드
        /// </summary>
        public string? SysCd { get; set; }

        /// <summary>
        /// 시스템 코드명
        /// </summary>
        public string? SysName { get; set; }

        /// <summary>
        /// 사업장 코드
        /// </summary>
        public string? BizCd { get; set; }

        /// <summary>
        /// 사업장명
        /// </summary>
        public string? BizName { get; set; }

        /// <summary>
        /// 사원 번호
        /// </summary>
        public string? EmpNo { get; set; }

        /// <summary>
        /// 전화 번호
        /// </summary>
        public string? TelNo { get; set; }

        /// <summary>
        /// 휴대폰 번호
        /// </summary>
        public string? MobPhoneNo { get; set; }

        /// <summary>
        /// 퇴사일/계정만료일
        /// </summary>
        public DateTime? RetireDate { get; set; }

        /// <summary>
        /// 관리자권한(사업장선택)
        /// </summary>
        public required string AdminFlag { get; set; }

        /// <summary>
        /// 공장구분
        /// </summary>
        public string? PlantDiv { get; set; }

        /// <summary>
        /// 업체코드
        /// </summary>
        public string? VendCd { get; set; }

        /// <summary>
        /// 고객코드
        /// </summary>
        public string? CustCd { get; set; }

        /// <summary>
        /// 사용자구분(T11 : 고객, T12 : 서연이화, T15 : 협력업체, T16:2차협력업체 )
        /// </summary>
        public required string UserDiv { get; set; }

        /// <summary>
        /// 패스워드 변경일
        /// </summary>
        public required DateTime PwdChgDate { get; set; }

        /// <summary>
        /// 패스워드 유효일자
        /// </summary>
        public required DateTime PwdValidDate { get; set; }

        /// <summary>
        /// 패스워드 변경요구 상태
        /// </summary>
        public required string PwdClearYn { get; set; }

        /// <summary>
        /// 패스워드 오류횟수
        /// </summary>
        public required int PwdErrCount { get; set; }

        /// <summary>
        /// 인증경로
        /// </summary>
        public required string CertCourse { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// 최종수정자
        /// </summary>
        public string? UpdateId { get; set; }

        /// <summary>
        /// 최초생성일_20200519추가
        /// </summary>
        public required DateTime InsertDate { get; set; }
    }
}
