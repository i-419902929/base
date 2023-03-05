using Volo.Abp.Reflection;

namespace Acme.BookStore.Permissions;

public class BookStorePermissions
{
    public const string GroupName = "BookStore";
    public const string Default = GroupName+ ".Default";
    public const string Query = GroupName + ".Query";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BookStorePermissions));
    }
}
