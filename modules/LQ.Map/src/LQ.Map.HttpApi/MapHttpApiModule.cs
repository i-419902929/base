using Localization.Resources.AbpUi;
using LQ.Map.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace LQ.Map;

[DependsOn(
    typeof(MapApplicationContractsModule)
    )]
public class MapHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<MapResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
