using System.Collections.Generic;
using System.Linq;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public class ConductorRepository : IConductorRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new User { UserId = "C001", Name = "Conductor One", Role = "Conductor", PasswordHash = "1234" },
            new User { UserId = "C002", Name = "Conductor Two", Role = "Conductor", PasswordHash = "5678" },
            new User { UserId = "A001", Name = "Admin", Role = "Admin", PasswordHash = "admin" }
        };

        public IEnumerable<User> GetAll() => _users;

        public User? GetById(string userId) => _users.FirstOrDefault(u => u.UserId == userId);
    }
}