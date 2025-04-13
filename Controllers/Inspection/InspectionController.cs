using GIT_KOREA_QA_API.Models.Inspection;
using GIT_KOREA_QA_API.Services.Common;
using GIT_KOREA_QA_API.Services.User;
using GIT_KOREA_QA_API.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Text.Json;

namespace GIT_KOREA_QA_API.Controllers.Inspection
{
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
        private readonly IConfiguration _configuration;
        private readonly string _basePath;
        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        private InspectionController(IFileUploadService fileUploadService, IConfiguration configuration)
        {
            _fileUploadService = fileUploadService;
            _configuration = configuration;
            _basePath = _configuration["UploadSettings:FolderPath"]!;

        }
        //-----------------------------------------------------------------------------
        //
        //  PUBLIC METHODS
        //
        //-----------------------------------------------------------------------------
        [HttpPost("seoyon/save")]
        public async Task<IActionResult> saveInspection()
        {
            var metadata = Request.Form["metadata"].FirstOrDefault()!; // 파일정보 외 데이터
            InspectionModelRequest model = JsonSerializer.Deserialize<InspectionModelRequest>(metadata)!;

            var uploadResults = await _fileUploadService.UploadFiles(Request.Form.Files.ToList());

            return Ok(uploadResults);
        }
        
    }
}
