using System.IO;
using BusTicketingSystem.Hardware;

namespace BusTicketingSystem.Hardware
{
    public class PrintingMachine : IDevice
    {
        private readonly string _logPath;
        public PrintingMachine()
        {
            _logPath = Path.Combine(System.AppContext.BaseDirectory, "printed_tickets.log");
        }

        public void Print(string content)
        {
            // Simple file write to simulate printing
            File.AppendAllText(_logPath, content + "\n---\n");
        }
    }
}