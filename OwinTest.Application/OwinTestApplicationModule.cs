using System.Reflection;
using Abp.Modules;

namespace OwinTest
{
    [DependsOn(typeof(OwinTestCoreModule))]
    public class OwinTestApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
