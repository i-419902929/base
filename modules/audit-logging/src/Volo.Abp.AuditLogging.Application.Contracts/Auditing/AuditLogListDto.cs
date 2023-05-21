using System;
using Volo.Abp.Application.Dtos;

namespace Volo.Abp.AuditLogging.Auditing;

public class AuditLogDto: EntityDto<Guid>
{
    public virtual string ApplicationName { get; set; }

    public virtual Guid? UserId { get;  set; }

    public virtual string UserName { get;  set; }

    public virtual Guid? TenantId { get;  set; }

    public virtual string TenantName { get;  set; }

    public virtual Guid? ImpersonatorUserId { get;  set; }

    public virtual string ImpersonatorUserName { get;  set; }

    public virtual Guid? ImpersonatorTenantId { get;  set; }

    public virtual string ImpersonatorTenantName { get;  set; }

    public virtual DateTime ExecutionTime { get;  set; }

    public virtual int ExecutionDuration { get; protected set; }

    public virtual string ClientIpAddress { get; protected set; }

    public virtual string ClientName { get; protected set; }

    public virtual string ClientId { get; set; }

    public virtual string CorrelationId { get; set; }

    public virtual string BrowserInfo { get; protected set; }

    public virtual string HttpMethod { get; protected set; }

    public virtual string Url { get; protected set; }

    public virtual string Exceptions { get; protected set; }

    public virtual string Comments { get; protected set; }

    public virtual int? HttpStatusCode { get; set; }
}
