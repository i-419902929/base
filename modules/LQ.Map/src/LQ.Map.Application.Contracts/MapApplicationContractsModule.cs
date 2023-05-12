using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace LQ.Map;

[DependsOn(
    typeof(MapDomainSharedModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpObjectExtendingModule)
)]
public class MapApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        MapDtoExtensions.Configure();
    }
}
