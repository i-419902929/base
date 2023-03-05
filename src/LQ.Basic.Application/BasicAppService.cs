using System;
using System.Collections.Generic;
using System.Text;
using LQ.Basic.Localization;
using Volo.Abp.Application.Services;

namespace LQ.Basic;

/* Inherit your application services from this class.
 */
public abstract class BasicAppService : ApplicationService
{
    protected BasicAppService()
    {
        LocalizationResource = typeof(BasicResource);
    }
}
