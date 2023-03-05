using LQ.Basic.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LQ.Basic;

[DependsOn(
    typeof(BasicEntityFrameworkCoreTestModule)
    )]
public class BasicDomainTestModule : AbpModule
{

}
