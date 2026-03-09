using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjectLibrary.BLL.Entities;
using ProjectLibrary.Common.Repositories;

namespace ProjectLibrary.ASPMVC.Handlers.Filters
{
    public class AdministratorFilter : IAuthorizationFilter
    {
        private readonly IUserRepository<BLL.Entities.User> _userService;
        private readonly UserSessionManager _userSession;

        public AdministratorFilter(UserSessionManager userSession, IUserRepository<User> userService)
        {
            _userSession = userSession;
            _userService = userService;
        }


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Guid? userId = _userSession.UserId;
            if (userId == null) {
                context.Result = new RedirectToActionResult("Login", "Auth", null);
            }

            if (!_userService.CheckAdmnistrator((Guid)userId))
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
            return;
            
        }
    }
}
