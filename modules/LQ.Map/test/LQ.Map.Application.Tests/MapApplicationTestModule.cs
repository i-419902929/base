using Volo.Abp.Modularity;

namespace LQ.Map;

[DependsOn(
    typeof(MapApplicationModule),
    typeof(MapDomainTestModule)
    )]
public class MapApplicationTestModule : AbpModule
{

}
