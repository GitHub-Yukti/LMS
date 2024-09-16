using Abp.AspNetCore.Mvc.ViewComponents;

namespace LMS.Web.Views
{
    public abstract class LMSViewComponent : AbpViewComponent
    {
        protected LMSViewComponent()
        {
            LocalizationSourceName = LMSConsts.LocalizationSourceName;
        }
    }
}
