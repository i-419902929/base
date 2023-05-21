using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AuditLogging.Auditing;

namespace Volo.Abp.AuditLogging.Auditlog;

[Area(AuditLoggingRemoteServiceConsts.ModuleName)]
[RemoteService(Name = AuditLoggingRemoteServiceConsts.RemoteServiceName)]
[Route("api/auditlogging/auditlog")]
public class AuditlogController : AuditLoggingController, IAuditLogAppService
{
    private readonly IAuditLogAppService auditLogAppService;

    public AuditlogController(IAuditLogAppService _auditLogAppService)
    {
        auditLogAppService = _auditLogAppService;
    }
    [HttpGet]
    [Route("GetAuditLogs")]
    public Task<PagedResultDto<AuditLogDto>> GetAuditLogs(GetAuditLogsInput input)
    {
        return auditLogAppService.GetAuditLogs(input);
    }
}
