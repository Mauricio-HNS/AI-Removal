using CliSecurityAgent.Domain;

namespace CliSecurityAgent.Infrastructure.Removal
{
    public class ThreatRemover
    {
        public bool Remove(string name)
        {
            // Simulação de remoção
            Console.WriteLine($"[SIMULATION] Removing {name}...");
            return true;
        }
    }
}
