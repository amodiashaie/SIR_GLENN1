using System;
using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BoholBusTicketingApp.Models
{
    public class DailyReport
    {
        public DateTime Date { get; set; }
        public int TotalTickets { get; set; }
        public double TotalFare { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
