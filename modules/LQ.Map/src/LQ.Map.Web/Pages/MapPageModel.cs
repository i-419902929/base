using LQ.Map.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LQ.Map.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MapPageModel : AbpPageModel
{
    protected MapPageModel()
    {
        LocalizationResourceType = typeof(MapResource);
    }
}
