using System.Reflection;
using Abp.Modules;
using OwinTest.Test;

namespace OwinTest
{
    [DependsOn(typeof(OwinTestCoreModule))]
    public class OwinTestApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            IocManager.Register<ITestService, TestService>(Abp.Dependency.DependencyLifeStyle.Transient);
        }
    }
}
