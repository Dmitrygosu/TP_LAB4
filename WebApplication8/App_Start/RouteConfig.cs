using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication8
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Default",
            url: "{area:exists}/{controller}/{action}/{uvar}",
                defaults: new { controller = "HomeController", action = "Index", uvar = UrlParameter.Optional },
             //new
             //{
             //   customConstraint = new UserAgentConstraint("Chrome")
             //},
             new[] { "UrlsAndRoutes.AdditionalControllers" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "MyHome", action = "MyIndex" }
            //);
            routes.MapRoute(
                name: "Second",
                url: "secondroute/{action}/{controller}/{uvar}",
                defaults: new { controller = "MyHome", action = "Index0", uvar = UrlParameter.Optional });


        }

    }
}
