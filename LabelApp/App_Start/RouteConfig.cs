﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LabelApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default/Pidsa",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "Pidsa", action = "Pidsa/Login", id = UrlParameter.Optional },
            //    new string[] { "Pidsa.Controllers" }
            //);
            routes.MapRoute(
            name: "Default/Pidsa",
            url: "{controller}/{action}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );
        }
    }
}
