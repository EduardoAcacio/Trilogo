using TQL.Domain.Entities;
using TQL.Domain.Interfaces.Repositories;

namespace TQL.Infra.Data.Repositories 
{
    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository 
    {
       
    }
}