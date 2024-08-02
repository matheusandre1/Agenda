using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Base
{
    public abstract class Entity<T>
    {
        protected Entity() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; protected set; }
    }
}
