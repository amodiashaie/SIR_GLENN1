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

        public bool PrintTicket(string ticketData)
        {
            if (!_isOnline)
                return false;

            try
            {
                // Print to console for visibility
                Console.WriteLine(ticketData);
                
                // Also write to file for logging
                File.AppendAllText(_logPath, ticketData + "\n---\n");
                return true;
            }
            catch
            {
                return false;
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
