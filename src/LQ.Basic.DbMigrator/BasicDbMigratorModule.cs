using LQ.Basic.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LQ.Basic.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BasicEntityFrameworkCoreModule),
    typeof(BasicApplicationContractsModule)
    )]
public class BasicDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
