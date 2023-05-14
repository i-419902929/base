using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LQ.Hangfire.Data;

public class HangfireDbContext : AbpDbContext<HangfireDbContext>
{
    public HangfireDbContext(DbContextOptions<HangfireDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */      
        builder.ConfigureAuditLogging();       
        /* Configure your own entities here */
    }
}
