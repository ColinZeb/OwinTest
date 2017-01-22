using System.Reflection;
using Abp.Modules;

namespace OwinTest
{
    public class OwinTestCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
