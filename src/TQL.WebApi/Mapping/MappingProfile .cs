using AutoMapper;
using TQL.Domain.Entities;
using TQL.WebApi.Models;

namespace TQL.WebApi.Mapping
{
    public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Ticket, TicketViewModel>();
            }
        }
}