using System;
using System.Collections.Generic;
using CliSecurityAgent.Domain.Entities; // <--- ESSA LINHA É ESSENCIAL

namespace CliSecurityAgent.Infrastructure.Detection
{
    public class ProcessScanner
    {
        public IEnumerable<Threat> Scan()
        {
            // implementação de scan
            return new List<Threat>();
        }
    }
}

