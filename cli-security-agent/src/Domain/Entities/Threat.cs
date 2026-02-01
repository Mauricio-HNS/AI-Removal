namespace CliSecurityAgent.Domain.Entities;

public class Threat
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public ThreatLevel Level { get; set; }
    public bool IsBlocked { get; set; }
    public bool IsRemoved { get; set; }
}
