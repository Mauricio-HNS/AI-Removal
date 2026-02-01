using CliSecurityAgent.Domain.Entities;
using System;

namespace CliSecurityAgent.Infrastructure.Removal
{
    public class ThreatRemover
    {
        public void Remove(Threat threat)
        {
            threat.IsRemoved = true;
            Console.WriteLine($"Removed: {threat.Name}");
        }
    }
}
