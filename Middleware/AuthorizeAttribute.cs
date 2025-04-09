using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GIT_KOREA_QA_API.Middleware
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string[] _roles;

        public AuthorizeAttribute(params string[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userId = context.HttpContext.Items["UserId"];
            var userRole = context.HttpContext.Items["UserRole"] as string;

            if (userId == null)
            {
                // 인증되지 않음
                context.Result = new UnauthorizedResult();
                return;
            }

            // 역할 검사
            if (_roles.Length > 0 && !_roles.Contains(userRole))
            {
                // 권한 없음
                context.Result = new ForbidResult();
                return;
            }
        }
    }
}
