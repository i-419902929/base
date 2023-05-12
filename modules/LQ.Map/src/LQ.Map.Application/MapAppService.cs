using System;
using System.Collections.Generic;
using System.Text;
using LQ.Map.Localization;
using Volo.Abp.Application.Services;

namespace LQ.Map;

/* Inherit your application services from this class.
 */
public abstract class MapAppService : ApplicationService
{
    protected MapAppService()
    {
        LocalizationResource = typeof(MapResource);
    }
}
