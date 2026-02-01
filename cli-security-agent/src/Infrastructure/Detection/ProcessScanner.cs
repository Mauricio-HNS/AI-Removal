using CliSecurityAgent.Domain.Entities;
using CliSecurityAgent.Domain.Interfaces;
using CliSecurityAgent.Domain.Enums;
using System.Collections.Generic;

namespace CliSecurityAgent.Infrastructure.Detection
{
    public class ProcessScanner : IThreatScanner
    {
        public List<Threat> Scan()
        {
            // Simulação de scan
            return new List<Threat>
            {
                new Threat { Name = "BadBot.exe", Path = "/usr/bin/BadBot.exe", Level = CliSecurityAgent.Domain.Entities.ThreatLevel.High },
                new Threat { Name = "UnknownProcess", Path = "/tmp/unknown", Level = CliSecurityAgent.Domain.Entities.ThreatLevel.Medium }
            };
        }
    }
}
