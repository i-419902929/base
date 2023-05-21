using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.AuditLogging.Auditing
{
    public interface INamespaceStripper
    {        string StripNameSpace(string serviceName);
    }
}
