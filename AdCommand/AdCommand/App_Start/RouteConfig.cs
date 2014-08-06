using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web.AdCommand {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");
            routes.MapRoute(
               name: "Default", // Route name
               url: "", // URL with parameters
               defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional } // Parameter defaults
           );
            routes.MapRoute(
                name: "adprovider", // Route name
                url: "adprovider/{action}/{id}", // URL with parameters
                defaults: new { controller = "AdProvider", action = "AdProvider", id = UrlParameter.Optional } // Parameter defaults
            );
            routes.MapRoute(
                name: "Country", // Route name
                url: "Country/{action}/{id}", // URL with parameters
                defaults: new { controller = "Country", action = "Country", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}