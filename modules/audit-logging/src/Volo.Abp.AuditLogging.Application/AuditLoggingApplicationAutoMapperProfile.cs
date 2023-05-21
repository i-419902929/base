using AutoMapper;
using Volo.Abp.AuditLogging.Auditing;

namespace Volo.Abp.AuditLogging;

public class AuditLoggingApplicationAutoMapperProfile : Profile
{
    public AuditLoggingApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<AuditLog, AuditLogDto>();
    }
}
