using Acme.BookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions;

public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookStorePermissions.GroupName, L("Permission:BookStore"));

        var rolesPermission = myGroup.AddPermission(BookStorePermissions.Default, L("Permission:RoleManagement"));
        rolesPermission.AddChild(BookStorePermissions.Query, L("Permission:Create"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreResource>(name);
    }
}
