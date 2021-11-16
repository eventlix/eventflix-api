namespace Eventflix.Domain.Establishments.Models
{
    public class EstablishmentDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}