using GIT_KOREA_QA_API.Exceptions;
using GIT_KOREA_QA_API.Models.Response;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace GIT_KOREA_QA_API.Filters
{
    public class ApiExceptionFilterAttribute : Microsoft.AspNetCore.Mvc.Filters.ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            // 이미 처리된 API 예외인 경우
            if (exception is ApiException apiException)
            {
                SetErrorResponse(context, apiException.StatusCode, apiException.Message, null);
                return;
            }

            // 다양한 예외 타입에 따른 처리
            if (exception is UnauthorizedAccessException)
            {
                SetErrorResponse(context, StatusCodes.Status401Unauthorized, "인증되지 않은 접근입니다.", null);
            }
            else if (exception is ArgumentException)
            {
                SetErrorResponse(context, StatusCodes.Status400BadRequest, "잘못된 요청입니다: " + exception.Message, null);
            }
            // 그 외 처리되지 않은 예외는 500 Internal Server Error로 처리
            else
            {
                SetErrorResponse(
                    context,
                    StatusCodes.Status500InternalServerError,
                    "서버 내부 오류가 발생했습니다.",
                    exception.Message);
            }
        }

        private void SetErrorResponse(
            ExceptionContext context,
            int statusCode,
            string message,
            string? detailedMessage)
        {
            var response = new ApiErrorResponse(statusCode, message, detailedMessage);

            context.Result = new ObjectResult(response)
            {
                StatusCode = statusCode
            };

            context.ExceptionHandled = true;
        }
    }
}
