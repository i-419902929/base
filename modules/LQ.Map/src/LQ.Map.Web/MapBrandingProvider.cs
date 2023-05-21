using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LQ.Map.Web;

[Dependency(ReplaceServices = true)]
public class MapBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "电子地图";
}
