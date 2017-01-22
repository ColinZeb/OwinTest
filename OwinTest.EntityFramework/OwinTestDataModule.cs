using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using OwinTest.EntityFramework;

namespace OwinTest
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(OwinTestCoreModule))]
    public class OwinTestDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<OwinTestDbContext>(null);
        }
    }
}
