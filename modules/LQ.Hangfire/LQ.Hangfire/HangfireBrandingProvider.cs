using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LQ.Hangfire;

[Dependency(ReplaceServices = true)]
public class HangfireBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Hangfire";
}
