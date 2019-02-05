using System;
using System.Collections.Generic;
using TQL.Application.Services;
using TQL.Domain.Entities;
using TQL.Domain.Interfaces.Services;

namespace TQL.Application.App
{
    public class TicketAppService : AppServiceBase<Ticket>, ITicketAppService
    {
        private readonly ITicketService _ticketService;

        public TicketAppService(ITicketService ticketService) 
            : base(ticketService)
        {
            _ticketService = ticketService;
        }
    }
}