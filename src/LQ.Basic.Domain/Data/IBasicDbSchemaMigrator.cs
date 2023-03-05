using System.Threading.Tasks;

namespace LQ.Basic.Data;

public interface IBasicDbSchemaMigrator
{
    Task MigrateAsync();
}
