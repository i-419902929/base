﻿using LQ.Map.Web.Components.Toolbar.LoginLink;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Users;

namespace LQ.Map.Web.Menus
{
    public class MapToolbarContributor : IToolbarContributor
    {
        public virtual Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
        {
            if (context.Toolbar.Name != StandardToolbars.Main)
            {
                return Task.CompletedTask;
            }

            if (!context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(LoginLinkViewComponent)));
            }

            return Task.CompletedTask;
        }
    }
}