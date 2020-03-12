using Abp.Web.Mvc.Views;

namespace MvC5.Web.Views
{
    public abstract class MvC5WebViewPageBase : MvC5WebViewPageBase<dynamic>
    {

    }

    public abstract class MvC5WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MvC5WebViewPageBase()
        {
            LocalizationSourceName = MvC5Consts.LocalizationSourceName;
        }
    }
}