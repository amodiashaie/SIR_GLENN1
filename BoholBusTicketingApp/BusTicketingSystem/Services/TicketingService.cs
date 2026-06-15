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

            // Print ticket
            try
            {
                string content = $"===== BOHOL BUS TICKET =====\n" +
                    $"Ticket ID: {ticket.ID}\n" +
                    $"Passenger: {ticket.PassengerName}\n" +
                    $"From: {ticket.FromLocation}\n" +
                    $"To: {ticket.ToLocation}\n" +
                    $"Fare: ₱{ticket.Fare:F2}\n" +
                    $"Date & Time: {ticket.DateIssued:yyyy-MM-dd HH:mm:ss}\n" +
                    $"=============================\n";
                
                if (_printer != null)
                {
                    bool printSuccess = _printer.PrintTicket(content);
                    if (!printSuccess)
                    {
                        throw new Exception("Printer is offline or unavailable");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Printing error: {ex.Message}");
                // Don't re-throw - ticket was created even if printing failed
            }
        }

        public List<Ticket> GetTicketsIssuedByDate(DateTime date)
        {
            var list = new List<Ticket>(_ticketRepo.QueryByDate(date));
            return list;
        }
    }
}
