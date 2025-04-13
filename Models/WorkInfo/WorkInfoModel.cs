namespace GIT_KOREA_QA_API.Models.WorkInfo
{
    /// <summary>
    /// 서연이화 작업정보입력 요청
    /// </summary>
    public class WorkInfoModelRequest
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        private string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        private string? Bizcd { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        private string? Vincd { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        private string? PlantDiv { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        private string? UseYn { get; set; }

        /// <summary>
        /// 등록년월
        /// </summary>
        private string? Yyyymm { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? LangSet { get; set; }
    }

    /// <summary>
    /// 서연이화 작업정보입력 응답
    /// </summary>
    public class WorkInfoModelResponse
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        private string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        private string? Bizcd { get; set; }

        /// <summary>
        /// 시리얼키
        /// </summary>
        private int Serial { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        private string? Vincd { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        private string? Linecd { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        private string? Install_pos { get; set; }

        /// <summary>
        /// 검사자 사번
        /// </summary>
        private string? Inspect_empno { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        private string? Use_yn { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        private string? Remark { get; set; }

        /// <summary>
        /// 등록일자
        /// </summary>
        private string? Reg_date { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        private string? Plant_div { get; set; }

        /// <summary>
        /// 라인코드명
        /// </summary>
        private string? Linenm { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? Wirte_date_cnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? Wirte_data_cnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? Problem_data_cnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? Write_data_color { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? Problem_data_color { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        private string? Username { get; set; }
    }

    /// <summary>
    /// 협력사 작업정보입력 요청
    /// </summary>
    public class VendorWorkInfoModelRequest
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        private string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        private string? Bizcd { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        private string? Vincd { get; set; }

        /// <summary>
        /// 품목코드
        /// </summary>
        private string? Itemcd { get; set; }

        /// <summary>
        /// 측정아이템명
        /// </summary>
        private string? MeasItemnm { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        private string? PlantDiv { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        private string? UseYn { get; set; }

        /// <summary>
        /// 작성년월
        /// </summary>
        private string? Yyyymm { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? LangSet { get; set; }
    }

    /// <summary>
    /// 협력사 작업정보입력 요청
    /// </summary>
    public class VendorWorkInfoModelResponse
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        private string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        private string? Bizcd { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        private int Serial { get; set; }

        /// <summary>
        /// 시료수
        /// </summary>
        private int SampleCnt { get; set; }

        /// <summary>
        /// 측정업체
        /// </summary>
        private string? MeasureVendcd { get; set; }

        /// <summary>
        /// SCM등록여부(Y/N)
        /// </summary>
        private string? ScmRegYn { get; set; }

        /// <summary>
        /// 사용여부(Y/N)
        /// </summary>
        private string? UseYn { get; set; }

        /// <summary>
        /// 비고
        /// </summary>
        private string? Remark { get; set; }

        /// <summary>
        /// 공장구분(유형코드 U9)
        /// </summary>
        private string? PlantDiv { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        private string? Vincd { get; set; }

        /// <summary>
        /// 품목코드
        /// </summary>
        private string? Itemcd { get; set; }

        /// <summary>
        /// 품명
        /// </summary>
        private string? Itemnm { get; set; }

        /// <summary>
        /// 검사분류코드
        /// </summary>
        private string? InspectClasscd { get; set; }

        /// <summary>
        /// 검사분류명
        /// </summary>
        private string? InspectClassnm { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private int WirteDateCnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private int WriteDataCnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private int ProblemDataCnt { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? ProblemDataColor { get; set; }

        /// <summary>
        /// TODO : 주석필요
        /// </summary>
        private string? WriteDataColor { get; set; }

    }
}
