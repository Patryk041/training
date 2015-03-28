using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TrainingFive
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "warrior",
                url: "{controller}",
                defaults: new { controller = "Warrior", action = "Index"},
                namespaces: new[] { "TrainingFive.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{name}",
                defaults: new { controller = "Home", action = "Index", name = UrlParameter.Optional }, //id = UrlParameter.Optional
                namespaces:new[] { "TrainingFive.Controllers" }
            );
        }
    }
}