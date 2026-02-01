using System.Collections.Generic;
using CliSecurityAgent.Application.DTOs;
using CliSecurityAgent.Domain;
using CliSecurityAgent.Infrastructure.Detection;
using CliSecurityAgent.Infrastructure.Blocking;
using CliSecurityAgent.Infrastructure.Removal;

namespace CliSecurityAgent.Application.Services
{
    public class ThreatService
    {
        private readonly ProcessScanner _scanner;
        private readonly ThreatRemover _remover;
        private readonly FirewallBlocker _blocker;

        public ThreatService()
        {
            _scanner = new ProcessScanner();
            _remover = new ThreatRemover();
            _blocker = new FirewallBlocker();
        }

        public List<ThreatResultDto> ScanThreats()
        {
            var threats = _scanner.Scan();
            var results = new List<ThreatResultDto>();

            foreach (var t in threats)
            {
                results.Add(new ThreatResultDto
                {
                    Name = t.Name,
                    Path = t.Path,
                    Level = t.Level.ToString()
                });
            }

            return results;
        }

        public bool RemoveThreat(string name)
        {
            return _remover.Remove(name);
        }

        public bool BlockThreat(string name)
        {
            return _blocker.Block(name);
        }
    }
}
        