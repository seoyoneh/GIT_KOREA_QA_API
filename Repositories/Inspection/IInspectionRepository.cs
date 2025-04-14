using GIT_KOREA_QA_API.Entity.Inspection;
using GIT_KOREA_QA_API.Models.Inspection;

namespace GIT_KOREA_QA_API.Repositories.Inspection
{
    public interface IInspectionRepository
    {
        /// <summary>
        /// 서연이화 등록된 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionResult> GetInspection(InspectionModelRequest request);

        /// <summary>
        /// 협력사 등록된 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VendorInspectionResult> GetVendor(VendorInspectionModelRequest request);

        /// <summary>
        /// 서연이화 검사결과 등록하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionResult> SaveInspection(InspectionModelRequest request);

        /// <summary>
        /// 협력사 검사결과 등록하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VendorInspectionResult> SaveInspection(VendorInspectionModelRequest request);
    }
}
