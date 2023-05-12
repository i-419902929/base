using LQ.Map.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LQ.Map.Permissions;

public class MapPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MapPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MapPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MapResource>(name);
    }
}
