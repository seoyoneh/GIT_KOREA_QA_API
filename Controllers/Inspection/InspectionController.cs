using GIT_KOREA_QA_API.Services.Common;
using GIT_KOREA_QA_API.Services.User;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;

namespace GIT_KOREA_QA_API.Controllers.Inspection
{
    public class InspectionController : ControllerBase
    {
        //-----------------------------------------------------------------------------
        //
        //  CONSTANTS
        //
        //-----------------------------------------------------------------------------
        private readonly IFileUploadService _fileUploadService;
        //-----------------------------------------------------------------------------
        //
        //  CONSTRUCTOR
        //
        //-----------------------------------------------------------------------------
        private InspectionController(IFileUploadService fileUploadService)
        {
            _fileUploadService = fileUploadService;
        }
        //-----------------------------------------------------------------------------
        //
        //  PUBLIC METHODS
        //
        //-----------------------------------------------------------------------------

        
    }
}
