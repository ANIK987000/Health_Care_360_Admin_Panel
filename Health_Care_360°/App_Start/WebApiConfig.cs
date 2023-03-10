using Health_Care_360_.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Services.Protocols;

namespace Health_Care_360_
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.Filters.Add(new ValidateModelAttribute());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "route1",
               routeTemplate: "api/{controller}/{name}",
               defaults: new { name = @"^[a-zA-Z]" }
           );

            //config.Routes.MapHttpRoute(
            //        name: "EmailRoute",
            //        routeTemplate: "api/{controller}/{email}",
            //        defaults: new { action = "GetByEmail" }
            // );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.EnableCors();

        }
    }
}
