using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public interface IConductorRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(string userId);
    }
}