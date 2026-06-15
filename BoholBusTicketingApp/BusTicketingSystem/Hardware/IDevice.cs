namespace BusTicketingSystem.Hardware
{
    public interface IDevice
    {
        bool PrintTicket(string ticketData);
        bool IsHardwareAvailable();
    }
}
