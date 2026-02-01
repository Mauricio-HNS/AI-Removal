using CliSecurityAgent.Application.Services;
using CliSecurityAgent.Domain.Entities;
using CliSecurityAgent.Infrastructure.Detection;
using System;
using System.Collections.Generic;

namespace CliSecurityAgent.Presentation.CLI
{
    public class CliHandler
    {
        private readonly ThreatService _service;

        public CliHandler()
        {
            _service = new ThreatService(new ProcessScanner());
        }

        public void RunScan()
        {
            List<Threat> threats = _service.ScanThreats();

            foreach (var t in threats)
            {
                Console.WriteLine($"Found threat: {t.Name} at {t.Path} - Level: {t.Level}");
                
                Console.Write("Block it? (y/n): ");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    _service.BlockThreat(t);
                }

                Console.Write("Remove it? (y/n): ");
                if (Console.ReadLine()?.ToLower() == "y")
                {
                    _service.RemoveThreat(t);
                }

                Console.WriteLine();
            }
        }
    }
}
