using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Volo.Abp.AuditLogging.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AuditLoggingPageModel : AbpPageModel
{
    protected AuditLoggingPageModel()
    {
        LocalizationResourceType = typeof(AuditLoggingResource);
        ObjectMapperContext = typeof(AuditLoggingWebModule);
    }
}
