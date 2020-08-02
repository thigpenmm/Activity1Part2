using System.Web.Mvc;
using System.Web.Routing;

namespace Activity1Part2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Test",
              url: "Test/{action}",
              defaults: new { controller = "Test", action = "Index" }
          );
        }
    }
}
