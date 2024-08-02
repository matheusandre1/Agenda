using Agenda.Domain.Agendas;
using Agenda.Domain.Base;

namespace Agenda.Domain.Agenda
{
    public  class Calendario : Entity<Guid>
    {
        public string Name { get; set; }
        private readonly List<Commitment> _commitment = new List<Commitment>();

        public void AddCommitment(Commitment commitment)
        {
            
            _commitment.Add(commitment);
        }

        public void RemoveCommitment(Commitment commitment)
        {

            _commitment.Remove(commitment);
        }
    }
}
   
