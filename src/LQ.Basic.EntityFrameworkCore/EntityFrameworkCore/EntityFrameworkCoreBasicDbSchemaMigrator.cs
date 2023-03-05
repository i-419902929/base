using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LQ.Basic.Data;
using Volo.Abp.DependencyInjection;

namespace LQ.Basic.EntityFrameworkCore;

public class EntityFrameworkCoreBasicDbSchemaMigrator
    : IBasicDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBasicDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BasicDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BasicDbContext>()
            .Database
            .MigrateAsync();
    }
}
