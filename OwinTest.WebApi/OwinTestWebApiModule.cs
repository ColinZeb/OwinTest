using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace OwinTest
{
    [DependsOn(typeof(AbpWebApiModule), typeof(OwinTestApplicationModule))]
    public class OwinTestWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(OwinTestApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
