using Volo.Abp.Reflection;

namespace Volo.Abp.AuditLogging.Permissions;

public class AuditLoggingPermissions
{
    public const string GroupName = "AuditLogging";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AuditLoggingPermissions));
    }
}
