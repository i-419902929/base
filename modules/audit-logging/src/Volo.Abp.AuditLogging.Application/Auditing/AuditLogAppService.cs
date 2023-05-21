using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Repositories;

namespace Volo.Abp.AuditLogging.Auditing;

[DisableAuditing]
//[Authorize(AuditLoggingPermissions.GroupName)]
public class AuditLogAppService : AuditLoggingAppService, IAuditLogAppService
{
    private readonly IRepository<AuditLog, Guid> _auditLogRepository;  
    public AuditLogAppService(
        IRepository<AuditLog, Guid> auditLogRepository)
    {
        _auditLogRepository = auditLogRepository;    
    }
    public async Task<PagedResultDto<AuditLogDto>> GetAuditLogs(GetAuditLogsInput input)
    {
        var query = (await _auditLogRepository.GetQueryableAsync())
           .WhereIf(!input.UserName.IsNullOrWhiteSpace(), item => item.UserName.Contains(input.UserName))
           .WhereIf(!input.ServiceName.IsNullOrWhiteSpace(), item => item.ApplicationName.Contains(input.ServiceName))
           .WhereIf(!input.MethodName.IsNullOrWhiteSpace(), item => item.HttpMethod.Contains(input.MethodName))
           .WhereIf(!input.BrowserInfo.IsNullOrWhiteSpace(), item => item.BrowserInfo.Contains(input.BrowserInfo))
           .WhereIf(input.MinExecutionDuration.HasValue && input.MinExecutionDuration > 0, item => item.ExecutionDuration >= input.MinExecutionDuration.Value)
           .WhereIf(input.MaxExecutionDuration.HasValue && input.MaxExecutionDuration < int.MaxValue, item => item.ExecutionDuration <= input.MaxExecutionDuration.Value)
           .WhereIf(input.HasException == true, item => item.Exceptions != null && item.Exceptions != "")
           .WhereIf(input.HasException == false, item => item.Exceptions == null || item.Exceptions == "");
        var resultCount = query.Count();
        query = query.OrderBy(input.Sorting?? "ExecutionTime DESC").PageBy(input);
        var queryResult = await AsyncExecuter.ToListAsync(query);
        return new PagedResultDto<AuditLogDto>(resultCount, ObjectMapper.Map<List<AuditLog>, List<AuditLogDto>>(queryResult));
    }


}
