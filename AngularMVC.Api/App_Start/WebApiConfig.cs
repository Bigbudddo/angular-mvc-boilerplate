using AngularMVC.Repositories;
using Unity;
using Unity.Lifetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularMVC.Api {

    public static class WebApiConfig {

        public static void Register(HttpConfiguration config) {
			// Web API configuration and services
			// Setup dependency injection services
			var container = new UnityContainer();
			container.RegisterType<INakamaRepository, NakamaRepository>(new HierarchicalLifetimeManager());

            // Enable Cors
            // note; you'll want to adjust cors to fit your needs as this just lets anyone into any methods/routes
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

			// Setup Unity/Dependency Injection
			config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
