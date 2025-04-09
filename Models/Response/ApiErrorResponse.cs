using System.Net;

namespace GIT_KOREA_QA_API.Models.Response
{
    public class ApiErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string DetailedMessage { get; set; }
        public string RequestId { get; set; }
        public DateTime TimeStamp { get; set; }

        public ApiErrorResponse(int statusCode, string message, string? detailedMessage)
        {
            StatusCode = statusCode;
            Message = message;
            DetailedMessage = detailedMessage == null ? "" : detailedMessage;
            RequestId = Guid.NewGuid().ToString();
            TimeStamp = DateTime.UtcNow;
        }
    }
}
