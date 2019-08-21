using FolderHierarchy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FolderHierarchy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Folders",
                url: "{*folderLink}",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { folderLink = new FolderRouteConstraint() }
            );
        }
    }
}
