using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private readonly List<Route> _routes = new List<Route>
        {
            new Route { Id = "R1", Name = "Route A", Locations = new[] { "Tagbilaran", "Panglao", "Baclayon" } },
            new Route { Id = "R2", Name = "Route B", Locations = new[] { "Loay", "Sierra Bullones", "Jagna" } }
        };

        public IEnumerable<Route> GetAll() => _routes;

        public Route? GetById(string id) => _routes.Find(r => r.Id == id);
    }
}