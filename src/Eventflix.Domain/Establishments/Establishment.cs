using Eventflix.Domain.Establishments.Enums;

namespace Eventflix.Domain.Establishments
{
    public class Establishment
    {
        public Establishment(string name, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            Status = EstablishmentStatus.WaitingAnalyze;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public EstablishmentStatus Status { get; private set; }
    }
}