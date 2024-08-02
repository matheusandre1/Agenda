using Agenda.Domain.Base;

namespace Agenda.Domain.Agenda
{
    public class User: Entity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}