using Abp.Owin;
using Abp.WebApi.Configuration;
using Microsoft.Owin;
using Owin;
using OwinTest;
using OwinTest.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

[assembly: OwinStartup(typeof(Startup))]
namespace OwinTest
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseAbp();
            // Configure Web API for self-host. 
            HttpConfiguration config = Abp.Dependency.IocManager.Instance.Resolve<IAbpWebApiConfiguration>().HttpConfiguration;
            WebApi(config);

            config.Filters.Add(new ApiFilter());
            appBuilder.UseWebApi(config);

            
        }

        private static void WebApi(HttpConfiguration config)
        {
            config.EnableDependencyInjection();
            config.EnsureInitialized();

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Movie>("Movie");
            builder.EnableLowerCamelCase();
            //config.MapODataServiceRoute("odataRoute", "odata", builder.GetEdmModel());
            //config.Count().Filter().OrderBy().Expand().Select().MaxTop(null); //new line

        }
    }
}
