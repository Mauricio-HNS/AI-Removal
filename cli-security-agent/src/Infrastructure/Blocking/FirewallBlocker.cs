using CliSecurityAgent.Domain;

namespace CliSecurityAgent.Infrastructure.Blocking
{
    public class FirewallBlocker
    {
        public bool Block(string name)
        {
            // Simulação de bloqueio
            Console.WriteLine($"[SIMULATION] Blocking {name} in firewall...");
            return true;
        }
    }
}
