using Abp.Web.Mvc.Views;

namespace OwinTest.Web.Views
{
    public abstract class OwinTestWebViewPageBase : OwinTestWebViewPageBase<dynamic>
    {

    }

    public abstract class OwinTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected OwinTestWebViewPageBase()
        {
            LocalizationSourceName = OwinTestConsts.LocalizationSourceName;
        }
    }
}