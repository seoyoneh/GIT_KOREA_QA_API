using GIT_KOREA_QA_API.Models.Inspection;
using GIT_KOREA_QA_API.Services.Common;

namespace GIT_KOREA_QA_API.Services.Inspection
{
    /// <summary>
    /// 검사결과 관련 처리 서비스
    /// </summary>
    public class InspectionService : IInspectionService
    {
        /// <summary>
        /// 서연이화 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<InspectionModelResponse> GetInspection(InspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 협력사 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<VendorInspectionModelResponse> GetVendorInspection(VendorInspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 서연이화 검사결과 저장하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<InspectionModelResponse> SaveInspection(InspectionModelRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 협력사 검사결과 저장하기
        /// </summary>
        /// <param name="request"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<VendorInspectionModelResponse> SaveVendorInspection(VendorInspectionModelResponse request, List<FileUploadResult> files)
        {
            throw new NotImplementedException();
        }
    }
}
