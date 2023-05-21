using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Volo.Abp.AuditLogging.Auditing;

public interface IAuditLogAppService : IApplicationService
{
    Task<PagedResultDto<AuditLogDto>> GetAuditLogs(GetAuditLogsInput input);
}
