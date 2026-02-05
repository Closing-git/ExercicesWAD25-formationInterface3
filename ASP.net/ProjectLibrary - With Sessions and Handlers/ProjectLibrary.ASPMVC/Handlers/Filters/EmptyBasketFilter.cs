using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjectLibrary.ASPMVC.Handlers.Filters
{
    public class EmptyBasketFilter : IAuthorizationFilter
    {

        private readonly RentSessionManager _rentSession;

        public EmptyBasketFilter(RentSessionManager rentSession)
        {
            _rentSession = rentSession;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (_rentSession.Basket.Count() == 0)
            {
                context.Result = new RedirectToActionResult("Index", "Book", null);
            }
        }
    }
    }

