namespace CliSecurityAgent.Application.DTOs
{
    public class ThreatResultDto
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Level { get; set; } = "Unknown";
        public bool IsBlocked { get; set; } = false;
    }
}
    