using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LQ.Basic.Data;

/* This is used if database provider does't define
 * IBasicDbSchemaMigrator implementation.
 */
public class NullBasicDbSchemaMigrator : IBasicDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
