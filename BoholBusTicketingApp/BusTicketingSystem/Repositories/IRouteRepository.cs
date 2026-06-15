using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public interface IRouteRepository
    {
        IEnumerable<Route> GetAll();
        Route? GetById(string id);
    }
}