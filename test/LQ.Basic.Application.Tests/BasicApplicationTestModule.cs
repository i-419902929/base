using Volo.Abp.Modularity;

namespace LQ.Basic;

[DependsOn(
    typeof(BasicApplicationModule),
    typeof(BasicDomainTestModule)
    )]
public class BasicApplicationTestModule : AbpModule
{

}
