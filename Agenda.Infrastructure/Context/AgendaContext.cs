using Agenda.Domain.Agenda;
using Agenda.Domain.Agendas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
