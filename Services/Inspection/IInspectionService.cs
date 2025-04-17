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
        Task<InspectionSeoyoneh_ModelResponse> GetInspection(InspectionSeoyoneh_ModelRequest request);

        /// <summary>
        /// 협력사 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionVendor_ModelResponse> GetVendorInspection(InspectionVendor_ModelRequest request);

        /// <summary>
        /// 서연이화 검사결과 저장
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionSeoyoneh_ModelResponse> SaveInspection(InspectionSeoyoneh_ModelRequest request);

        /// <summary>
        /// 협력사 검사결과 저장
        /// </summary>
        /// <param name="request"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        Task<InspectionVendor_ModelResponse> SaveVendorInspection(InspectionVendor_ModelResponse request, List<FileUploadResult> files);
    }
}
