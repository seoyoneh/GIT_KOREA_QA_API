using System.Reflection.Metadata;
using Swashbuckle.AspNetCore.Annotations;

namespace GIT_KOREA_QA_API.Models.Inspection
{
    /// <summary>
    /// 서연이화 검사결과등록 모델(요청)
    /// </summary>
    public class InspectionSeoyoneh_ModelRequest
    {
        /// <summary>
        /// 법인코드
        /// </summary>
        public string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        public string? Bizcd { get; set; }

        /// <summary>
        /// 차종코드
        /// </summary>
        public string? Vincd { get; set; }

        /// <summary>
        /// Langage Set
        /// </summary>
        public string? LangSet { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 사용자 아이디
        /// </summary>
        public string? UserId { get; set; }


    }

    /// <summary>
    /// 서연이화 검사결과등록 모델(응답)
    /// </summary>
    public class InspectionSeoyoneh_ModelResponse
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 차종 코드
        /// </summary>
        public string? Vincd { get; set; }

        /// <summary>
        /// 라인 코드
        /// </summary>
        public string? Linecd { get; set; }

        /// <summary>
        /// 라인 이름
        /// </summary>
        public string? Linenm { get; set; }

        /// <summary>
        /// 주간 초품
        /// </summary>
        public string? JoCho { get; set; }

        /// <summary>
        /// 주간 중품
        /// </summary>
        public string? JoJung { get; set; }

        /// <summary>
        /// 야간 초품
        /// </summary>
        public string? YaCho { get; set; }

        /// <summary>
        /// 야간 중품
        /// </summary>
        public string? YaJung { get; set; }

        /// <summary>
        /// 측정 항목명
        /// </summary>
        public string? MeasItemnm { get; set; }

        /// <summary>
        /// 주야구분(FKY / FKN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// 이상 발생 여부 (Y/N)
        /// </summary>
        public string? DnDivnm { get; set; }

        /// <summary>
        /// 초/중품 구분(PTF / PTM)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        public string? FmlDivnm { get; set; }

        /// <summary>
        /// 제조 LOT NO
        /// </summary>
        public string? ProdLotno { get; set; }

        /// <summary>
        /// 이상발생여부 (Y/N)
        /// </summary>
        public string? ProblemYn { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자 ID
        /// </summary>
        public string? Insertnm { get; set; }

        /// <summary>
        /// 최초 등록 일시
        /// </summary>
        public string? InsertDate { get; set; }

        /// <summary>
        /// 최종 수정자 ID
        /// </summary>
        public string? Updatenm { get; set; }

        /// <summary>
        /// 최종 수정 일시
        /// </summary>
        public string? UpdateDate { get; set; }

        /// <summary>
        /// 제품 사진 ID 1
        /// </summary>
        public string? ProdImageId1 { get; set; }

        /// <summary>
        /// 제품 사진 ID 2
        /// </summary>
        public string? ProdImageId2 { get; set; }

        /// <summary>
        /// 제품 사진 ID 3
        /// </summary>
        public string? ProdImageId3 { get; set; }

        /// <summary>
        /// 기준검사서 사전
        /// </summary>
        public Blob StdPhoto { get; set; }

        /// <summary>
        /// PPT 파일명
        /// </summary>
        public string? PptFileName { get; set; }

        /// <summary>
        /// PPT 파일 크기
        /// </summary>
        public string? PptFileSize { get; set; }

        /// <summary>
        /// 이미지 파일
        /// </summary>
        public string? ImgFile { get; set; }

        /// <summary>
        /// 이미지 파일명
        /// </summary>
        public string? ImgFileName { get; set; }

        /// <summary>
        /// 이미지 파일 크기
        /// </summary>
        public string? ImgFileSize { get; set; }

        /// <summary>
        /// SEQ
        /// </summary>
        public string? Seq { get; set; }

        /// <summary>
        /// 제품 사진 1
        /// </summary>
        public Blob? ProdImage { get; set; }

        /// <summary>
        /// 제품 사진 2
        /// </summary>
        public Blob? ProdImage2 { get; set; }

        /// <summary>
        /// 제품 사진 3
        /// </summary>
        public Blob? ProdImage3 { get; set; }

        /// <summary>
        /// 기준 검사서 파일 ID
        /// </summary>
        public string? StdPhotoFileId { get; set; }
    }

    /// <summary>
    /// 서연이화 검사결과등록 모델(요청)
    /// </summary>
    public class InspectionSeoyonehDetail_ModelRequest
    {
        /// <summary>
        /// Langage Set
        /// </summary>
        public string? LangSet { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 시리얼
        /// </summary>
        public string? UserId { get; set; }

    }

    /// <summary>
    /// 서연이화 검사결과등록 모델(응답)
    /// </summary>
    public class InspectionSeoyonehDetail_ModelResponse
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 차종 코드
        /// </summary>
        public string? Vincd { get; set; }

        /// <summary>
        /// 라인 코드
        /// </summary>
        public string? Linecd { get; set; }

        /// <summary>
        /// 라인 이름
        /// </summary>
        public string? Linenm { get; set; }

        /// <summary>
        /// 주간 초품
        /// </summary>
        public string? JoCho { get; set; }

        /// <summary>
        /// 주간 중품
        /// </summary>
        public string? JoJung { get; set; }

        /// <summary>
        /// 야간 초품
        /// </summary>
        public string? YaCho { get; set; }

        /// <summary>
        /// 야간 중품
        /// </summary>
        public string? YaJung { get; set; }

        /// <summary>
        /// 측정 항목명
        /// </summary>
        public string? MeasItemnm { get; set; }

        /// <summary>
        /// 주야구분(FKY / FKN)
        /// </summary>
        public string? DnDiv { get; set; }

        /// <summary>
        /// 이상 발생 여부 (Y/N)
        /// </summary>
        public string? DnDivnm { get; set; }

        /// <summary>
        /// 초/중품 구분(PTF / PTM)
        /// </summary>
        public string? FmlDiv { get; set; }

        /// <summary>
        /// FML 구분명
        /// </summary>
        public string? FmlDivnm { get; set; }

        /// <summary>
        /// 제조 LOT NO
        /// </summary>
        public string? ProdLotno { get; set; }

        /// <summary>
        /// 이상발생여부 (Y/N)
        /// </summary>
        public string? ProblemYn { get; set; }

        /// <summary>
        /// 조치결과
        /// </summary>
        public string? MgrtResult { get; set; }

        /// <summary>
        /// 최초 등록자 ID
        /// </summary>
        public string? Insertnm { get; set; }

        /// <summary>
        /// 최초 등록 일시
        /// </summary>
        public string? InsertDate { get; set; }

        /// <summary>
        /// 최종 수정자 ID
        /// </summary>
        public string? Updatenm { get; set; }

        /// <summary>
        /// 최종 수정 일시
        /// </summary>
        public string? UpdateDate { get; set; }

        /// <summary>
        /// 제품 사진 ID 1
        /// </summary>
        public string? ProdImageId1 { get; set; }

        /// <summary>
        /// 제품 사진 ID 2
        /// </summary>
        public string? ProdImageId2 { get; set; }

        /// <summary>
        /// 제품 사진 ID 3
        /// </summary>
        public string? ProdImageId3 { get; set; }

        /// <summary>
        /// 기준검사서 사전
        /// </summary>
        public Blob StdPhoto { get; set; }

        /// <summary>
        /// PPT 파일명
        /// </summary>
        public string? PptFileName { get; set; }

        /// <summary>
        /// PPT 파일 크기
        /// </summary>
        public string? PptFileSize { get; set; }

        /// <summary>
        /// 이미지 파일
        /// </summary>
        public string? ImgFile { get; set; }

        /// <summary>
        /// 이미지 파일명
        /// </summary>
        public string? ImgFileName { get; set; }

        /// <summary>
        /// 이미지 파일 크기
        /// </summary>
        public string? ImgFileSize { get; set; }

        /// <summary>
        /// SEQ
        /// </summary>
        public string? Seq { get; set; }

        /// <summary>
        /// 제품 사진 1
        /// </summary>
        public Blob? ProdImage { get; set; }

        /// <summary>
        /// 제품 사진 2
        /// </summary>
        public Blob? ProdImage2 { get; set; }

        /// <summary>
        /// 제품 사진 3
        /// </summary>
        public Blob? ProdImage3 { get; set; }

        /// <summary>
        /// 기준 검사서 파일 ID
        /// </summary>
        public string? StdPhotoFileId { get; set; }
    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(요청)
    /// </summary>
    public class InspectionVendor_ModelRequest
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        public int? Serial { get; set; }

        /// <summary>
        /// 법인코드
        /// </summary>
        public string? Corcd { get; set; }

        /// <summary>
        /// 사업장코드
        /// </summary>
        public string? Bizcd { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? UserId { get; set; }

    }


    /// <summary>
    /// 협력사 검사결과 등록 모델(응답)
    /// </summary>
    public class InspectionVendor_ModelResponse
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

    /// <summary>
    /// 협력사 검사결과 등록 모델(요청)
    /// </summary>
    public class InspectionVendorDetail_ModelRequest
    {
        /// <summary>
        /// 시리얼
        /// </summary>
        public string? Serial { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? MeasDate { get; set; }

        /// <summary>
        /// 측정일자
        /// </summary>
        public string? LangSet { get; set; }

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
        public List<IFormFile>? Files { get; set; }
    }

    /// <summary>
    /// 협력사 검사결과 등록 모델(응답)
    /// </summary>
    public class InspectionVendorDetail_ModelResponse
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
