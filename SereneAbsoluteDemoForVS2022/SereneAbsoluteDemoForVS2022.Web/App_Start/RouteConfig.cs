using System.Web.Mvc;
using System.Web.Routing;

namespace SereneAbsoluteDemoForVS2022
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
        }
    }
}