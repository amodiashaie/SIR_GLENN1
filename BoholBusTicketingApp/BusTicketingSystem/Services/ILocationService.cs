using System.Collections.Generic;

namespace BusTicketingSystem.Services
{
    public interface ILocationService
    {
        List<string> GetLocations();
    }
}