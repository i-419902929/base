using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LQ.Map.Data;

/* This is used if database provider does't define
 * IMapDbSchemaMigrator implementation.
 */
public class NullMapDbSchemaMigrator : IMapDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
