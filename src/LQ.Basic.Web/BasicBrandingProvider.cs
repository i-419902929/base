using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LQ.Basic.Web;

[Dependency(ReplaceServices = true)]
public class BasicBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Basic";
}
