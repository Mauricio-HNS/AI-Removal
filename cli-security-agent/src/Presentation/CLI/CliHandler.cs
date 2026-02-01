using System;
using System.Linq;
using CliSecurityAgent.Application.Services;
using CliSecurityAgent.Application.DTOs;

namespace CliSecurityAgent.Presentation.CLI
{
    public class CliHandler
    {
        private readonly ThreatService _service;

        public CliHandler()
        {
            _service = new ThreatService();
        }

        public void RunScan()
        {
            var threats = _service.ScanThreats();

            if (!threats.Any())
            {
                Console.WriteLine("No threats found.");
                return;
            }

            Console.WriteLine("Threats detected:");
            int index = 1;
            foreach (var t in threats)
            {
                Console.WriteLine($"{index}. [{t.Level}] {t.Name} at {t.Path}");
                index++;
            }

            foreach (var t in threats)
            {
                Console.WriteLine($"\nAction for {t.Name} (Level: {t.Level})?");
                Console.WriteLine("1 - Block only");
                Console.WriteLine("2 - Remove");
                Console.WriteLine("3 - Skip");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        if (_service.BlockThreat(t.Name))
                            Console.WriteLine($"{t.Name} blocked successfully.");
                        break;
                    case "2":
                        if (_service.RemoveThreat(t.Name))
                            Console.WriteLine($"{t.Name} removed successfully.");
                        break;
                    case "3":
                        Console.WriteLine($"{t.Name} skipped.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Skipping...");
                        break;
                }
            }
        }
    }
}
