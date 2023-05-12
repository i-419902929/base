using System.Threading.Tasks;

namespace LQ.Map.Data;

public interface IMapDbSchemaMigrator
{
    Task MigrateAsync();
}
