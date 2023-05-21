using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Volo.Abp.AuditLogging;

public abstract class AuditLoggingController : AbpControllerBase
{
    protected AuditLoggingController()
    {
        LocalizationResource = typeof(AuditLoggingResource);
    }
}
