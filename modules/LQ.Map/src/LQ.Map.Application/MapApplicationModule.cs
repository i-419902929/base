using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace LQ.Map;

[DependsOn(
    typeof(MapDomainModule), 
    typeof(MapApplicationContractsModule)
   
    )]
public class MapApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<MapApplicationModule>();
        });
    }
}
