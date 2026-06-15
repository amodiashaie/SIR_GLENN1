using System;
using System.Collections.Generic;
using System.Linq;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly List<Ticket> _tickets = new List<Ticket>();

        public void Add(Ticket ticket)
        {
            _tickets.Add(ticket);
        }

        public IEnumerable<Ticket> QueryByDate(DateTime date)
        {
            return _tickets.Where(t => t.DateIssued.Date == date.Date).ToList();
        }
    }
}