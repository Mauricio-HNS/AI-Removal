using CliSecurityAgent.Domain.Enums;

namespace CliSecurityAgent.Application.DTOs
{
    public class ThreatResultDto
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ThreatLevel Level { get; set; }
    }
}
