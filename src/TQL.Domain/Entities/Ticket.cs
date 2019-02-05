using System;

namespace TQL.Domain.Entities
{
    public class Ticket 
    {
        protected Ticket() {}

        public Ticket(string description, string author)
        {
            Description = description;
            Author = author;
            CreationDate = DateTime.Now;
            Updated = DateTime.Now;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime Updated { get; set; }
    }
}