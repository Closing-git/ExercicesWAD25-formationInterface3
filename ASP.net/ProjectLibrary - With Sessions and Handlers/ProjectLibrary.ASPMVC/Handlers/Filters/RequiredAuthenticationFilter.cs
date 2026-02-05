using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace ProjectLibrary.ASPMVC.Handlers.Filters
{
    public class RequiredAuthenticationFilter : IAuthorizationFilter
    {

        //Peut être simplifié via UserSessionManager (voir dans AnonymousFilter)
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            ISession session = context.HttpContext.Session;

            Guid? userId = JsonSerializer.Deserialize<Guid?>(session.GetString("UserId") ?? "null");

            if (userId == null)
            {
                context.Result = new RedirectToActionResult("Login", "Auth", null);
            }
        }
    }
}
