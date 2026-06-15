namespace BusTicketingSystem.Models
{
    public class User
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = "Conductor"; // Admin or Conductor
        public string PasswordHash { get; set; } = string.Empty;
    }
}