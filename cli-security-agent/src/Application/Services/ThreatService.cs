using CliSecurityAgent.Domain.Entities;
using CliSecurityAgent.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace CliSecurityAgent.Application.Services
{
    public class ThreatService
    {
        private readonly IThreatScanner _scanner;

        public ThreatService(IThreatScanner scanner)
        {
            _scanner = scanner;
        }

        public List<Threat> ScanThreats()
        {
            return _scanner.Scan();
        }

        public void BlockThreat(Threat threat)
        {
            threat.IsBlocked = true;
            Console.WriteLine($"Threat blocked: {threat.Name}");
        }

        public void RemoveThreat(Threat threat)
        {
            threat.IsRemoved = true;
            Console.WriteLine($"Threat removed: {threat.Name}");
        }
    }
}
