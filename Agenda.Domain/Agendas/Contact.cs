

using Agenda.Domain.Base;

namespace Agenda.Domain.Agendas
{
    public class Contact: Entity<Guid>
    {
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;

        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

       

    }
}
