namespace CliSecurityAgent.Domain
{
    public class Threat
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ThreatLevel Level { get; set; }
    }
}
