using CliSecurityAgent.Domain.Entities;
using System;

namespace CliSecurityAgent.Infrastructure.Blocking
{
    public class FirewallBlocker
    {
        public void Block(Threat threat)
        {
            threat.IsBlocked = true;
            Console.WriteLine($"[FIREWALL BLOCKED] {threat.Name}");
        }
    }
}
