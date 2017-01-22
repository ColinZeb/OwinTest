using Abp.Web.Mvc.Controllers;

namespace OwinTest.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class OwinTestControllerBase : AbpController
    {
        protected OwinTestControllerBase()
        {
            LocalizationSourceName = OwinTestConsts.LocalizationSourceName;
        }
    }
}