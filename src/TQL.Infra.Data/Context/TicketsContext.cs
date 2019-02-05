using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TQL.Domain.Entities;

namespace TQL.Infra.Data
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions options) : base(options) {}
        public TicketsContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TicketsDB");
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Updated") != null))
            {
                if (entry.State == EntityState.Added || entry.State == EntityState.Modified )
                {
                    entry.Property("Updated").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Unchanged )
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
