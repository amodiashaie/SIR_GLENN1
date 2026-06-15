using System;

namespace BusTicketingSystem.Models
{
    public class Ticket
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string? ConductorId { get; set; }
        public string? PassengerName { get; set; }
        public string? Route { get; set; }
        public string? FromLocation { get; set; }
        public string? ToLocation { get; set; }
        public double Fare { get; set; }
        public DateTime DateIssued { get; set; }
    }
}