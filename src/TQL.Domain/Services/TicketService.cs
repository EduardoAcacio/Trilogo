using System;
using System.Collections.Generic;
using TQL.Domain.Entities;
using TQL.Domain.Interfaces.Repositories;
using TQL.Domain.Interfaces.Services;

namespace TQL.Domain.Services
{
    public class TicketService : ServiceBase<Ticket>, ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
            : base(ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
    }
}