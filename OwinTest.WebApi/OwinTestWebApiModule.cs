using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using System.Web.Http;
using Abp.WebApi.Configuration;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace OwinTest
{
    [DependsOn(typeof(AbpWebApiModule), typeof(OwinTestApplicationModule))]
    public class OwinTestWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            var config = new HttpConfiguration();
            IocManager.Resolve<IAbpWebApiConfiguration>().HttpConfiguration = config;
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Movie>("Movie");
            builder.EnableLowerCamelCase();
            config.MapODataServiceRoute("odataRoute", "odata", builder.GetEdmModel());
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null); //new line
            base.PreInitialize();
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(OwinTestApplicationModule).Assembly, "app")
                .Build();
        }
        public override void PostInitialize()
        {
            base.PostInitialize();
        }
    }
}
