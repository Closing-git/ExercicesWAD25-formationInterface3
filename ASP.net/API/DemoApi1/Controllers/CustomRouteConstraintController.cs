using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomRouteConstraintController : ControllerBase
    {
        //postNow ici est le nom donné dans program.cs à ma routeConstraint : PostCurrentDateConstraint
        [HttpGet("{date:postNow}")]
        public int Get(DateOnly date)
        {
            return (int)(DateTime.Now - new DateTime(date, new TimeOnly())).TotalDays;
        }

    }
}
