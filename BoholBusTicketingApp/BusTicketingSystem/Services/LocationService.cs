using System.Collections.Generic;
using System.Linq;
using BusTicketingSystem.Repositories;

namespace BusTicketingSystem.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRouteRepository _routeRepo;

        public LocationService(IRouteRepository routeRepo)
        {
            _routeRepo = routeRepo;
        }

        public List<string> GetLocations()
        {
            return _routeRepo.GetAll().SelectMany(r => r.Locations).Distinct().ToList();
        }
    }
}