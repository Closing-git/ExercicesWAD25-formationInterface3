
namespace DemoApi1.Handlers.RouteConstraints
{
    public class PostCurrentDateConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey(routeKey)) {
                return false;
            }
            try
            {
                DateOnly value = DateOnly.Parse(values[routeKey].ToString());
                return value < DateOnly.FromDateTime(DateTime.Now);
            }

            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
