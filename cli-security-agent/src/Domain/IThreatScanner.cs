using CliSecurityAgent.Domain.Entities;
using System.Collections.Generic;

namespace CliSecurityAgent.Domain.Interfaces
{
    public interface IThreatScanner
    {
        List<Threat> Scan();
    }
}
