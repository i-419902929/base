using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace LQ.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling
{
    public class AdminLTEThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/adminlte/css/adminlte.css");
            context.Files.Add("/themes/adminlte/css/OverlayScrollbars.css");
        }
    }
}
