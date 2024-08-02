using Agenda.Domain.Agenda;
using Agenda.Domain.Agendas;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Agenda.Domain.Agendas;


namespace Agenda.Infrastructure.Context
{
    public  class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options ) : base(options) 
        { 

        }

        public DbSet<Commitment> Compromissos { get; set; }

        public DbSet<Calendar> Calendarios {  get; set; }
        
        public DbSet<User> Usuarios { get; set; }

        public DbSet<Agenda.Domain.Agendas.Agenda> Agendas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AgendaContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
