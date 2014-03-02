using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TestCrossDomainB
{
    public static class WebApiConfig
    {
        public static string UrlPrefix { get { return "api"; } }
        public static string UrlPrefixRelative { get { return "~/api"; } }

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var route = config.Routes.MapHttpRoute(
                name: "ActionApi",
                routeTemplate: UrlPrefix + "/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
