using Abp.Application.Services;

namespace OwinTest
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class OwinTestAppServiceBase : ApplicationService
    {
        protected OwinTestAppServiceBase()
        {
            LocalizationSourceName = OwinTestConsts.LocalizationSourceName;
        }
    }
}