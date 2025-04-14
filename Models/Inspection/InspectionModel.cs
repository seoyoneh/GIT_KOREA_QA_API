using Swashbuckle.AspNetCore.Annotations;

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
        public int Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        public string? TargetDiv { get; set; }


        /// <summary>
        /// 제조LOTNO
        /// </summary>
        public string? ProdLotno { get; set; }


        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        public string? ProdImageId1 { get; set; }


        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        public string? ProdImageId2 { get; set; }


        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        public string? ProdImageId3 { get; set; }


        /// <summary>
        /// 제품사진명1
        /// </summary>
        public string? ProdImageNm1 { get; set; }


        /// <summary>
        /// 제품사진명2
        /// </summary>
        public string? ProdImageNm2 { get; set; }


        /// <summary>
        /// 제품사진명3
        /// </summary>
        public string? ProdImageNm3 { get; set; }


        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        public string? ProblemYn { get; set; }


        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }


        /// <summary>
        /// 사용자 ID
        /// </summary>
        public string? UserId { get; set; }


        /// <summary>
        /// 검사자 사번
        /// </summary>
        public string? InspectEmpno { get; set; }


        /// <summary>
        /// 차종
        /// </summary>
        public string? Vincd { get; set; }


        /// <summary>
        /// 라인코드
        /// </summary>
        public string? Linecd { get; set; }


        /// <summary>
        /// 장착위치
        /// </summary>
        public string? InstallPos { get; set; }


        /// <summary>
        /// 품명
        /// </summary>
        public string? Itemnm { get; set; }
    }

    /// <summary>
    /// 서연이화 검사결과등록 모델(응답)
    /// </summary>
    public class InspectionModelResponse
    {
        /// <summary>
        /// 주야구분(유형코드 : FN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        public string? InsertDate { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        public string? InsertId { get; set; }

        /// <summary>
        /// 검사자 사번
        /// </summary>
        public string? InspectEmpno { get; set; }

        /// <summary>
        /// 장착위치
        /// </summary>
        public string? InstallPos { get; set; }

        /// <summary>
        /// 품명
        /// </summary>
        public string? Itemnm { get; set; }

        /// <summary>
        /// 라인코드
        /// </summary>
        public string? Linecd { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        public string? ProblemYn { get; set; }

        /// <summary>
        /// 제품사진 ID1
        /// </summary>
        public string? ProdImageId1 { get; set; }

        /// <summary>
        /// 제품사진 ID2
        /// </summary>
        public string? ProdImageId2 { get; set; }

        /// <summary>
        /// 제품사진 ID3
        /// </summary>
        public string? ProdImageId3 { get; set; }

        /// <summary>
        /// 제품사진명1
        /// </summary>
        public string? ProdImageNm1 { get; set; }

        /// <summary>
        /// 제품사진명2
        /// </summary>
        public string? ProdImageNm2 { get; set; }

        /// <summary>
        /// 제품사진명3
        /// </summary>
        public string? ProdImageNm3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        public string? ProdLotno { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        public string? TargetDiv { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        public string? UpdateDate { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        public string? UpdateId { get; set; }

        /// <summary>
        /// 차종
        /// </summary>
        public string? Vincd {  get; set; }
    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(요청)
    /// </summary>
    public class VendorInspectionModelRequest
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        public int? Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 검사자 이름
        /// </summary>
        public string? ManagerNm { get; set; }

        /// <summary>
        /// 주야구분(유형코드: FN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// 대상구분
        /// </summary>
        public string? TargetDiv { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        public string? ProdLotno { get; set; }

        /// <summary>
        /// 제품사진1(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        [SwaggerIgnore]
        public byte[]? ProdImage { get; set; }

        /// <summary>
        /// 제품사진2(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        [SwaggerIgnore]
        public byte[]? ProdImage2 { get; set; }

        /// <summary>
        /// 제품사진3(FormData로 전송하면 Backend에서 처리해 채워넣음)
        /// </summary>
        [SwaggerIgnore]
        public byte[]? ProdImage3 { get; set; }

        /// <summary>
        /// 이상발생유무
        /// </summary>

        public string? ProblemYn { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }

        /// <summary>
        /// 사용자 ID(사용자 토큰에서 확인하여 채워넣음)
        /// </summary>
        public string? UserId { get; set; }

        /// <summary>
        /// 업로드 파일 목록
        /// </summary>
        public List<IFormFile> Files { get; set; }
    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(응답)
    /// </summary>
    public class VendorInspectionModelResponse
    {
        /// <summary>
        /// 주야구분(유형코두 : FN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// FML구분(유형코드 : PT)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// 최초등록일시
        /// </summary>
        public string? InsertDate { get; set; }

        /// <summary>
        /// 최초등록자ID
        /// </summary>
        public string? InsertId { get; set; }

        /// <summary>
        /// 관리자이름
        /// </summary>
        public string? ManagerNm { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }

        /// <summary>
        /// 이상발생여부(Y/N)
        /// </summary>
        public string? ProblemYn { get; set; }

        /// <summary>
        /// 제품사진1
        /// </summary>
        public string? ProdImage { get; set; }

        /// <summary>
        /// 제품사진2
        /// </summary>
        public string? ProdImage2 { get; set; }

        /// <summary>
        /// 제품사진3
        /// </summary>
        public string? ProdImage3 { get; set; }

        /// <summary>
        /// 제조LOTNO
        /// </summary>
        public string? ProdLotno { get; set; }

        /// <summary>
        /// 시리얼번호
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 대상구분(유형코드 : FL
        /// </summary>
        public string? TargetDiv { get; set; }

        /// <summary>
        /// 최종수정일시
        /// </summary>
        public string? UpdateDate { get; set; }

        /// <summary>
        /// 최총수정자ID
        /// </summary>
        public string? UpdateId { get; set; }
    }
}
