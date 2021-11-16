using Eventflix.Domain.Establishments;
using Eventflix.Domain.Establishments.Enums;
using Xunit;

namespace Eventflix.Domain.Tests.Establishments
{
    public class EstablishmentTests
    {
        [Fact]
        public void ShouldReturnAwaitingAnalyseWhenCreatedCorrectly()
        {
            // arrange

            var establishment = new Establishment(
                name: "Establishment Test"
            );

            // act

            var stablishmentStatus = establishment.Status;

            // assert

            Assert.Equal(EstablishmentStatus.WaitingAnalyze, establishment.Status);
        }
    }
}