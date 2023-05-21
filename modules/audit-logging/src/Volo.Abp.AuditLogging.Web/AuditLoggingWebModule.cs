using LQ.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE;
using LQ.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AuditLogging.Localization;
using Volo.Abp.AuditLogging.Web.Menus;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.AuditLogging.Web;

[DependsOn(
    typeof(AuditLoggingApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUIAdminLTEThemeModule),
    typeof(AbpAutoMapperModule)
    )]
public class AuditLoggingWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(AuditLoggingResource), typeof(AuditLoggingWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AuditLoggingWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new AuditLoggingMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AuditLoggingWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<AuditLoggingWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AuditLoggingWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
            //Configure authorization.
        });
        Configure<AbpBundlingOptions>(options =>
        {
            options.ScriptBundles.Configure(
                AdminLTEThemeBundles.Scripts.Global,
                bundle =>
                {
                    bundle.AddFiles("/client-proxies/auditlog-proxy.js");
                }
            );
        });
    }
}
