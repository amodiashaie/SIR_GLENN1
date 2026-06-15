namespace BusTicketingSystem.Models
{
    public class Route
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string[] Locations { get; set; } = new string[0];
    }
}