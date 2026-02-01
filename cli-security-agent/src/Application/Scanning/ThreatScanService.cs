using CliSecurityAgent.Domain;
using CliSecurityAgent.Domain.Interfaces;
using System.Linq;

namespace CliSecurityAgent.Application.Scanning
{
    public class ThreatScanService
    {
        private readonly IThreatScanner[] _scanners;

        public ThreatScanService(IThreatScanner[] scanners)
        {
            _scanners = scanners;
        }

        public Threat[] Execute()
        {
            return _scanners.SelectMany(s => s.Scan()).ToArray();
        }
    }
}
