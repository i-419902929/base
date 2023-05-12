using LQ.Map.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LQ.Map.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MapController : AbpControllerBase
{
    protected MapController()
    {
        LocalizationResource = typeof(MapResource);
    }
}
