using Microsoft.Extensions.Primitives;
using System.Net.Sockets;
using System.Net;
using System.Runtime.CompilerServices;

namespace GIT_KOREA_QA_API.Utils
{
    public class IPExtractorUtil
    {
        /// <summary>
        /// 요청 클라이언트의 IP주소를 추출하는 메서드
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetClientIPv4(HttpRequest request)
        {
            // 1. X-Forwarded-For 확인
            if (request.Headers.TryGetValue("X-Forwarded-For", out StringValues forwardedValues) &&
                !StringValues.IsNullOrEmpty(forwardedValues))
            {
                string forwardedIp = forwardedValues.ToString().Split(',')[0].Trim();
                if (IPAddress.TryParse(forwardedIp, out IPAddress? parsedIP))
                {
                    if (parsedIP.AddressFamily == AddressFamily.InterNetwork)
                        return parsedIP.ToString();

                    if (parsedIP.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        try { return parsedIP.MapToIPv4().ToString(); }
                        catch { /* 변환 불가능한 IPv6 주소 */ }
                    }
                }
            }

            // 2. X-Real-IP 확인 (많은 프록시에서 사용)
            if (request.Headers.TryGetValue("X-Real-IP", out StringValues realValues) &&
                !StringValues.IsNullOrEmpty(realValues))
            {
                string realIp = realValues.ToString().Trim();
                if (IPAddress.TryParse(realIp, out IPAddress? parsedIP))
                {
                    if (parsedIP.AddressFamily == AddressFamily.InterNetwork)
                        return parsedIP.ToString();

                    if (parsedIP.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        try { return parsedIP.MapToIPv4().ToString(); }
                        catch { /* 변환 불가능한 IPv6 주소 */ }
                    }
                }
            }

            // 3. 직접 연결 IP 확인
            var remoteIp = request.HttpContext.Connection.RemoteIpAddress;
            if (remoteIp != null)
            {
                if (remoteIp.AddressFamily == AddressFamily.InterNetwork)
                    return remoteIp.ToString();

                if (remoteIp.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    try { return remoteIp.MapToIPv4().ToString(); }
                    catch { /* 변환 불가능한 IPv6 주소 */ }
                }
            }

            return "Unknown";
        }
    }
}
