using System;
using CliSecurityAgent.Presentation.CLI;

namespace CliSecurityAgent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CLI Security Agent ===");
            Console.WriteLine("Scanning for threats...\n");

            try
            {
                // Inicializa a CLI handler
                var cli = new CliHandler();

                // Executa o scan interativo
                cli.RunScan();

                Console.WriteLine("\nScan complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
