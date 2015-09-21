using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Upload",
                url: "Employee/BulkUpload",
                defaults: new { controller = "BulkUpload", action = "Index" }
            );

            //routes.MapRoute(
            //    "MyRoute",
            //    "Employee/{EmpId}",
            //    new { controller = " Employee ", action = "GetEmployeeById" },
            //    new { EmpId = @"\d+" }
            // );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
