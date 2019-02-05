using System;

namespace TQL.WebApi.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
    }
}