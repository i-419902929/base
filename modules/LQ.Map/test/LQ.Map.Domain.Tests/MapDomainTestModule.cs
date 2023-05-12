using LQ.Map.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LQ.Map;

[DependsOn(
    typeof(MapEntityFrameworkCoreTestModule)
    )]
public class MapDomainTestModule : AbpModule
{

}
