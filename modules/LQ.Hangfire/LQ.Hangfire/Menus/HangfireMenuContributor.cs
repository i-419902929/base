using LQ.Hangfire.Localization;
using Volo.Abp.UI.Navigation;

namespace LQ.Hangfire.Menus;

public class HangfireMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<HangfireResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                HangfireMenus.Home,
                l["Menu:Home"],
                "~/Hangfire",
                icon: "fas fa-home",
                order: 0
            )
        );

      

        return Task.CompletedTask;
    }
}
