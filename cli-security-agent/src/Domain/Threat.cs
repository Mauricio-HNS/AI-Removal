namespace CliSecurityAgent.Domain.Entities
{
    public class Threat
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ThreatLevel Level { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool IsRemoved { get; set; } = false;
    }

    public enum ThreatLevel
    {
        Low,
        Medium,
        High,
        Critical
    }
}
