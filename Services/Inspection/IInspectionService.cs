using GIT_KOREA_QA_API.Models.Inspection;
using GIT_KOREA_QA_API.Services.Common;

namespace GIT_KOREA_QA_API.Services.Inspection
{
    public interface IInspectionService
    {
        /// <summary>
        /// 서연이화 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionModelResponse> GetInspection(InspectionModelRequest request);

        /// <summary>
        /// 협력사 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VendorInspectionModelResponse> GetVendorInspection(VendorInspectionModelRequest request);

        /// <summary>
        /// 서연이화 검사결과 저장
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionModelResponse> SaveInspection(InspectionModelRequest request);

        /// <summary>
        /// 협력사 검사결과 저장
        /// </summary>
        /// <param name="request"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<VendorInspectionModelResponse> SaveVendorInspection(VendorInspectionModelResponse request, List<FileUploadResult> files);
    }
}
