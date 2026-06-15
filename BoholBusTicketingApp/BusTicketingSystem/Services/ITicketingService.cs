using System;
using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Services
{
    public interface ITicketingService
    {
        void CreateTicket(Ticket ticket);
        List<Ticket> GetTicketsIssuedByDate(DateTime date);
    }
}