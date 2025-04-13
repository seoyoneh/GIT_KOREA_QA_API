namespace GIT_KOREA_QA_API.Models.Inspection
{
    /// <summary>
    /// 서연이화 검사결과등록 모델(요청)
    /// </summary>
    public class InspectionModelRequest
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        private int Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        private string? MeasDate { get; set; }

        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        private string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        private string? FmlDiv { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        private string? TargetDiv { get; set; }


        /// <summary>
        /// 제조LOTNO
        /// </summary>
        private string? ProdLotno { get; set; }


        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        private string? ProdImageId1 { get; set; }


        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        private string? ProdImageId2 { get; set; }


        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        private string? ProdImageId3 { get; set; }


        /// <summary>
        /// 제품사진명1
        /// </summary>
        private string? ProdImageNm1 { get; set; }


        /// <summary>
        /// 제품사진명2
        /// </summary>
        private string? ProdImageNm2 { get; set; }


        /// <summary>
        /// 제품사진명3
        /// </summary>
        private string? ProdImageNm3 { get; set; }


        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        private string? ProblemYn { get; set; }


        /// <summary>
        /// 조치결과
        /// </summary>
        private string? MgrtResult { get; set; }


        /// <summary>
        /// 사용자 ID
        /// </summary>
        private string? UserId { get; set; }


        /// <summary>
        /// 검사자 사번
        /// </summary>
        private string? InspectEmpno { get; set; }


        /// <summary>
        /// 차종
        /// </summary>
        private string? Vincd { get; set; }


        /// <summary>
        /// 라인코드
        /// </summary>
        private string? Linecd { get; set; }


        /// <summary>
        /// 장착위치
        /// </summary>
        private string? InstallPos { get; set; }


        /// <summary>
        /// 품명
        /// </summary>
        private string? Itemnm { get; set; }
    }

    /// <summary>
    /// 서연이화 검사결과등록 모델(응답)
    /// </summary>
    public class InspectionModelResponse
    {
        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        private string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        private string? FmlDiv { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        private string? InsertDate { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        private string? InsertId { get; set; }

        /// <summary>
        /// 검사자 사번
        /// </summary>
        private string? InspectEmpno { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        private string? InstallPos { get; set; }

        /// <summary>
        /// 품명
        /// </summary>
        private string? Itemnm { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        private string? Linecd { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        private string? MeasDate { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        private string? MgrtResult { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        private string? ProblemYn { get; set; }

        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        private string? ProdImageId1 { get; set; }

        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        private string? ProdImageId2 { get; set; }

        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        private string? ProdImageId3 { get; set; }

        /// <summary>
        /// 제품사진명1
        /// </summary>
        private string? ProdImageNm1 { get; set; }

        /// <summary>
        /// 제품사진명2
        /// </summary>
        private string? ProdImageNm2 { get; set; }

        /// <summary>
        /// 제품사진명3
        /// </summary>
        private string? ProdImageNm3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        private string? ProdLotno { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        private string? Serial { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        private string? TargetDiv { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        private string? UpdateDate { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        private string? UpdateId { get; set; }

        /// <summary>
        /// 차종
        /// </summary>
        private string? Vincd {  get; set; }
    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(요청)
    /// </summary>
    public class VendorInspectionModelRequest
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        private int? Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        private string? MeasDate { get; set; }

        /// <summary>
        /// 검사자 이름
        /// </summary>
        private string? ManagerNm { get; set; }

        /// <summary>
        /// 주야구분(유형코드: FN)
        /// </summary>
        private string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        private string? FmlDiv { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        private string? TargetDiv { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        private string? ProdLotno { get; set; }

        /// <summary>
        /// 제품사진1(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        private byte[]? ProdImage { get; set; }

        /// <summary>
        /// 제품사진2(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        private byte[]? ProdImage2 { get; set; }

        /// <summary>
        /// 제품사진3(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        private byte[]? ProdImage3 { get; set; }

        /// <summary>
        /// 이상발생유무
        /// </summary>

        private string? ProblemYn { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        private string? MgrtResult { get; set; }

        /// <summary>
        /// 사용자 ID(사용자 토큰에서 확인하여 채워넣음)
        /// </summary>
        private string? UserId { get; set; }

    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(응답)
    /// </summary>
    public class VendorInspectionModelResponse
    {
        /// <summary>
        /// 주야구분(유형코두 : FN)
        /// </summary>
        private string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        private string? FmlDiv { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        private string? InsertDate { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        private string? InsertId { get; set; }

        /// <summary>
        /// 관리자이름
        /// </summary>
        private string? ManagerNm { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        private string? MeasDate { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        private string? MgrtResult { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        private string? ProblemYn { get; set; }

        /// <summary>
        /// 제품사진1
        /// </summary>
        private string? ProdImage { get; set; }

        /// <summary>
        /// 제품사진2
        /// </summary>
        private string? ProdImage2 { get; set; }

        /// <summary>
        /// 제품사진3
        /// </summary>
        private string? ProdImage3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        private string? ProdLotno { get; set; }

        /// <summary>
        /// 시리얼번호
        /// </summary>
        private string? Serial { get; set; }

        /// <summary>
        /// 대상구분(유형코드 : FL
        /// </summary>
        private string? TargetDiv { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        private string? UpdateDate { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        private string? UpdateId { get; set; }
    }
}
