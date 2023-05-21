using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Volo.Abp.AuditLogging;

[DependsOn(
    typeof(AbpAuditLoggingDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AuditLoggingApplicationContractsModule : AbpModule
{

}
