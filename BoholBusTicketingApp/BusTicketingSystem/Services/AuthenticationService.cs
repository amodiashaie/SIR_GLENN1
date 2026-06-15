using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;

namespace BusTicketingSystem.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConductorRepository _conductorRepo;
        private User? _current;

        public AuthenticationService(IConductorRepository conductorRepo)
        {
            _conductorRepo = conductorRepo;
        }

        public User? Authenticate(string username, string password)
        {
            // Very simple auth for demo: username is userId, password matches PasswordHash field
            var user = _conductorRepo.GetById(username);
            if (user != null && user.PasswordHash == password)
            {
                _current = user;
                return user;
            }
            return null;
        }

        public void Logout()
        {
            _current = null;
        }
    }
}