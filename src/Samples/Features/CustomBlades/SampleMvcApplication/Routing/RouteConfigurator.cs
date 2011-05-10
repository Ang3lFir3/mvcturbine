﻿namespace MvcTurbine.Samples.CustomBlades.Routing {
    using System.Web.Mvc;
    using System.Web.Routing;
    using MvcTurbine.Routing;

    public class RouteConfigurator : IRouteRegistrator {
        public void Register(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default",
                            "{controller}/{action}/{id}",
                            new { controller = "Home", action = "Index", id = "" });
        }
    }
}