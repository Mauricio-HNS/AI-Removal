using CliSecurityAgent.Domain.Entities;

namespace CliSecurityAgent.Domain;

public interface IThreatScanner
{
    IEnumerable<Threat> Scan();
}
