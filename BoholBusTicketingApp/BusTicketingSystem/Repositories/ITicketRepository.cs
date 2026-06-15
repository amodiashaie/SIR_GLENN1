using System;
using System.Collections.Generic;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public interface ITicketRepository
    {
        void Add(Ticket ticket);
        IEnumerable<Ticket> QueryByDate(DateTime date);
    }
}