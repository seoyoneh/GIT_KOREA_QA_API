using GIT_KOREA_QA_API.Models.Inspection;
using GIT_KOREA_QA_API.Services.Common;
using GIT_KOREA_QA_API.Services.Inspection;
using GIT_KOREA_QA_API.Services.User;
using GIT_KOREA_QA_API.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Text.Json;

namespace GIT_KOREA_QA_API.Controllers.Inspection
{
    /// <summary>
    /// 초중품 검사결과 등록
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class InspectionController : ControllerBase
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly IFileUploadService _fileUploadService;
        private readonly IInspectionService _InspectionService;
        private readonly IConfiguration _configuration;
        private readonly string _basePath;
        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        public InspectionController(
            IFileUploadService fileUploadService,
            IInspectionService InspectionService,
            IConfiguration configuration)
        {
            _fileUploadService = fileUploadService;
            _InspectionService = InspectionService;
            _configuration = configuration;
            _basePath = _configuration["UploadSettings:FolderPath"]!;

        }
        //-----------------------------------------------------------------------------
        //
        //  PUBLIC METHODS
        //
        //-----------------------------------------------------------------------------
        /// <summary>
        /// 초중품 검사결과 조회
        /// </summary>
        /// <returns></returns>
        [HttpPost("inquery/seoyoneh")]
        public async Task<IActionResult> GetInspection(InspectionSeoyoneh_ModelRequest request)
        {
            var result = await _InspectionService.GetSeoyonehInspection(request);
            //var uploadResults = await _fileUploadService.UploadFiles(files);

            return Ok();
        }

        /// <summary>
        /// 초중품 검사결과 조회
        /// </summary>
        /// <returns></returns>
        [HttpPost("inquery/vendor")]
        public async Task<IActionResult> GetInspection(InspectionVendor_ModelRequest request)
        {
            var result = await _InspectionService.GetVendorInspection(request);
            //var uploadResults = await _fileUploadService.UploadFiles(files);

            return Ok();
        }

        /// <summary>
        /// 초중품 검사결과 조회
        /// </summary>
        /// <returns></returns>
        [HttpPost("inquery/seoyoneh/detail")]
        public async Task<IActionResult> GetInspection(InspectionSeoyonehDetail_ModelRequest request)
        {
            var result = await _InspectionService.GetSeoyonehDetailInspection(request);
            //var uploadResults = await _fileUploadService.UploadFiles(files);

            return Ok();
        }

        /// <summary>
        /// 초중품 검사결과 조회
        /// </summary>
        /// <returns></returns>
        [HttpPost("inquery/vendor/detail")]
        public async Task<IActionResult> GetInspection(InspectionVendorDetail_ModelRequest request)
        {
            var result = await _InspectionService.GetVendorDetailInspection(request);
            //var uploadResults = await _fileUploadService.UploadFiles(files);

            return Ok();
        }

        /// <summary>
        /// 초중품 검사결과 저장
        /// </summary>
        /// <returns></returns>
        [HttpPost("seoyon/save")]
        public async Task<IActionResult> SaveInspection(InspectionSeoyoneh_ModelRequest request)
        {
            var result = await _InspectionService.SaveInspection(request);
            //var uploadResults = await _fileUploadService.UploadFiles(files);

            return Ok();
        }

        /// <summary>
        /// 협력사 초중품 검사결과 저장
        /// </summary>
        /// <param name="request">협력사 검사결과 등록 요청</param>
        /// <returns></returns>
        [HttpPost("vendor/save")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> SaveVendorInspection([FromForm] InspectionVendor_ModelRequest request)
        {
            // var metadata = Request.Form["metadata"].FirstOrDefault()!; // 파일정보 외 데이터
            // InspectionModelRequest model = JsonSerializer.Deserialize<InspectionModelRequest>(metadata)!;
            // var uploadResults = await _fileUploadService.UploadFiles(files);

            //var uploadResults = await _fileUploadService.UploadFiles(request.Files!, false);

            return Ok();
        }

    }
}
