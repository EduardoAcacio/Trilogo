using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TQL.Application.Services;
using TQL.Domain.Entities;
using TQL.WebApi.Models;

namespace TQL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
         private readonly ITicketAppService _ticketApp;
         private readonly IMapper _mapper;

         public TicketsController(ITicketAppService ticketApp, IMapper mapper)
         {
            _ticketApp = ticketApp;
            _mapper = mapper;
         }

         // GET api/ticket
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> TQL()
        {   
            return _ticketApp.GetAll();
        }
    }
}