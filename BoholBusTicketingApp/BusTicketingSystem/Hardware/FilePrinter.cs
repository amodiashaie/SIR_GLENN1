using System;
using System.IO;

namespace BusTicketingSystem.Hardware
{
    public class PrintingMachine : IDevice
    {
        private readonly string _logPath;
        private bool _isOnline = true;

        public PrintingMachine()
        {
            _logPath = Path.Combine(AppContext.BaseDirectory, "printed_tickets.log");
        }

        public void Print(string content)
        {
            if (!_isOnline)
                return;

            try
            {
                // Print to console for visibility
                Console.WriteLine(content);
                
                // Also write to file for logging
                File.AppendAllText(_logPath, content + "\n---\n");
            }
            catch
            {
                // Silently fail if printing fails
            }
        }

        public bool IsHardwareAvailable()
        {
            return _isOnline;
        }

        public void SetOnline(bool isOnline)
        {
            _isOnline = isOnline;
        }
    }
}
