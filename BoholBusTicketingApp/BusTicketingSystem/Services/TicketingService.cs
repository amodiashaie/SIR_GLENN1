using System;
using System.Collections.Generic;
using BusTicketingSystem.Hardware;
using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;

namespace BusTicketingSystem.Services
{
    public class TicketingService : ITicketingService
    {
        private readonly IConductorRepository _conductorRepo;
        private readonly ITicketRepository _ticketRepo;
        private readonly IRouteRepository _routeRepo;
        private readonly IDevice _printer;

        public TicketingService(IConductorRepository conductorRepo, ITicketRepository ticketRepo, IRouteRepository routeRepo, IDevice printer)
        {
            _conductorRepo = conductorRepo;
            _ticketRepo = ticketRepo;
            _routeRepo = routeRepo;
            _printer = printer;
        }

        public void CreateTicket(Ticket ticket)
        {
            ticket.DateIssued = DateTime.Now;
            _ticketRepo.Add(ticket);

            // Print
            try
            {
                string content = $"Ticket:{ticket.ID}\nPassenger:{ticket.PassengerName}\nFrom:{ticket.FromLocation}\nTo:{ticket.ToLocation}\nFare:{ticket.Fare:F2}\nTime:{ticket.DateIssued:yyyy-MM-dd HH:mm:ss}\n";
                _printer.Print(content);
            }
            catch
            {
                // swallow for now, could log and surface error
            }
        }

        public List<Ticket> GetTicketsIssuedByDate(DateTime date)
        {
            var list = new List<Ticket>(_ticketRepo.QueryByDate(date));
            return list;
        }
    }
}