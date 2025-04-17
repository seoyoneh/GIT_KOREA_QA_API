using GIT_KOREA_QA_API.Entity.Inspection;
using GIT_KOREA_QA_API.Entity.User;
using GIT_KOREA_QA_API.Exceptions;
using GIT_KOREA_QA_API.Models.Inspection;
using GIT_KOREA_QA_API.Models.User;
using GIT_KOREA_QA_API.Repositories.Inspection;
using GIT_KOREA_QA_API.Repositories.User;
using GIT_KOREA_QA_API.Services.Common;

namespace GIT_KOREA_QA_API.Services.Inspection
{
    /// <summary>
    /// 검사결과 관련 처리 서비스
    /// </summary>
    public class InspectionService : IInspectionService
    {
        private readonly IInspectionRepository _inspectionRepository;
        private readonly IConfiguration _configuration;

        public InspectionService(IInspectionRepository inspectionRepository, IConfiguration configuration)
        {
            _inspectionRepository = inspectionRepository;
            _configuration = configuration;
        }

        /// <summary>
        /// 서연이화 검사결과 조회하기
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<InspectionModelResponse> GetInspection(InspectionModelRequest request)
        {
            Inquery_SeoyonehResult? inspectionInfo;

            inspectionInfo = await _inspectionRepository.GetInspection(request);

            if (inspectionInfo == null)
            {
                throw new ApiException(StatusCodes.Status404NotFound, "사용자를 찾을 수 없습니다.");
            }
            else
            {
                var result = new InspectionModelResponse
                {
                    Serial = ""
                };

                return result;
            }

            //throw new NotImplementedException();
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
