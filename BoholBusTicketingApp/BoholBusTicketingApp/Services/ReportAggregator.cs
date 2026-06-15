using System;
using System.Collections.Generic;
using System.Linq;
using BusTicketingSystem.Models;

namespace BoholBusTicketingApp.Services
{
    public static class ReportAggregator
    {
        public static (int totalTickets, double totalFare) Aggregate(IEnumerable<Ticket> tickets)
        {
            if (tickets == null) return (0, 0);
            int count = 0;
            double fare = 0;
            foreach (var t in tickets)
            {
                count++;
                fare += t?.Fare ?? 0;
            }
            return (count, fare);
        }

        public static Models.DailyReport BuildDailyReport(DateTime date, IEnumerable<Ticket> tickets)
        {
            var list = (tickets ?? Enumerable.Empty<Ticket>()).ToList();
            var (totalTickets, totalFare) = Aggregate(list);
            return new Models.DailyReport
            {
                Date = date.Date,
                TotalTickets = totalTickets,
                TotalFare = totalFare,
                Tickets = list
            };
        }
    }
}
