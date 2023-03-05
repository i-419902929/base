using LQ.Basic.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LQ.Basic.Web.Pages;

public abstract class BasicPageModel : AbpPageModel
{
    protected BasicPageModel()
    {
        LocalizationResourceType = typeof(BasicResource);
    }
}
