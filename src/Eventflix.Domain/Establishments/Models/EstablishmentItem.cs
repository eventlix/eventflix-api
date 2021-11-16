namespace Eventflix.Domain.Establishments.Models
{
    public class EstablishmentItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}