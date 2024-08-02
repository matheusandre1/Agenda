using Agenda.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Agendas
{
    public  class Agenda : Entity<Guid>
    {
        public string Name { get; protected set; }

        protected List<Contact> Contatos { get; set; } = new List<Contact>();


        public Agenda(string name)
        {
            Name = name;
            Contatos = new List<Contact>();
        }


        public void AddContact(Contact contact)
        {
            Contatos.Add(contact);
        }

        public void RemoveContact(Contact contact)
        { 
            Contatos.Remove(contact);
        }
    }
}
