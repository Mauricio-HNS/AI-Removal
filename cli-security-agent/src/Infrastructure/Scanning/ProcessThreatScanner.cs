using CliSecurityAgent.Domain;
using CliSecurityAgent.Domain.Interfaces;

namespace CliSecurityAgent.Infrastructure.Scanning
{
    public class ProcessThreatScanner : IThreatScanner
    {
        public Threat[] Scan()
        {
            return new Threat[0];
        }
    }
}
