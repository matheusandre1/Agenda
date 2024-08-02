using Agenda.Domain.Base;

namespace Agenda.Domain.Agendas
{
    public class Commitment: Entity<Guid>
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void Reagendar(DateTime newStartTime, DateTime newEndTime)
        {
            StartTime = newStartTime;
            EndTime = newEndTime;
        }
    }
}