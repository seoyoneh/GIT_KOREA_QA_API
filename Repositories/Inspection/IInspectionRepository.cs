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
        Task<Inquery_SeoyonehResult> GetInspection_Seoyoneh(InspectionSeoyoneh_ModelRequest request);

        /// <summary>
        /// 협력사 등록된 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Inquery_VendorResult> GetInspection_Vendor(InspectionVendor_ModelRequest request);

        /// <summary>
        /// 서연이화 등록된 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Inquery_Seoyoneh_DetailResult> GetInspection_Seoyoneh_Detail(InspectionSeoyonehDetail_ModelRequest request);

        /// <summary>
        /// 협력사 등록된 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Inquery_Vendor_DetailResult> GetInspection_Vendor_Detail(InspectionVendorDetail_ModelRequest request);

        /// <summary>
        /// 서연이화 검사결과 등록하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<InspectionResult> SaveInspection(InspectionSeoyoneh_ModelRequest request);

        /// <summary>
        /// 협력사 검사결과 등록하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<VendorInspectionResult> SaveInspection(InspectionVendor_ModelRequest request);
    }
}
