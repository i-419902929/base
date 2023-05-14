using Dapper;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.Dapper;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace LQ.Hangfire.Repositorys
{
    public class UserDapperRepository : DapperRepository<IdentityDbContext>, ITransientDependency
    {
        public UserDapperRepository(IDbContextProvider<IdentityDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public virtual async Task<List<string>> GetAllPersonNames()
        {
            return (await DbConnection.QueryAsync<string>("select Name from People", transaction: DbTransaction))
                .ToList();
        }

        public virtual async Task<int> UpdatePersonNames(string name)
        {
            return await DbConnection.ExecuteAsync("update People set Name = @NewName", new { NewName = name },
                DbTransaction);
        }
    }
}
