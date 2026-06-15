using BusTicketingSystem.Models;

namespace BusTicketingSystem.Services
{
    public interface IAuthenticationService
    {
        User? Authenticate(string username, string password);
        void Logout();
    }
}