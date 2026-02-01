using CliSecurityAgent.Domain;

namespace CliSecurityAgent.Domain.Interfaces
{
    public interface IThreatScanner
    {
        Threat[] Scan();
    }
}
