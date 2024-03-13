using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Rently
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Actionss",
            //    url: "Customers",
            //    defaults: new { controller = "Customer" }
            //);

            routes.MapRoute(
                name: "Cars",
                url: "Cars",
                defaults: new { controller = "Car", action = "Index" }
            );

            routes.MapRoute(
                name: "Action",
                url: "Car/Action/{year}/{month}",
                defaults: new { controller = "Car", action = "Action"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
