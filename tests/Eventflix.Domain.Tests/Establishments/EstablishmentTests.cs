using Eventflix.Domain.Establishments;
using Eventflix.Domain.Establishments.Enums;
using Xunit;

namespace Eventflix.Domain.Tests.Establishments
{
    public class EstablishmentTests
    {
        [Fact(DisplayName = "Deve retornar o status 'Aguardando Análise' quando criado corretamente")]
        public void Should()
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