using CalculadoraDeJuros.Domain.Domain.Entities;
using CalculadoraDeJuros.Infra.Repository.Repositories;
using Xunit;

namespace CalculadoraDeJuros.Tests.RepositoryTests
{
    public class CalculaJurosRepositoryTests
    {
        [Theory]
        [InlineData(100.0, 5, 0.01, 105.10)]
        public void ShouldReturnSuccessWhenValorFinalEqualsExpected(double valorInicial, int meses, double juros, double expected)
        {
            #region Arrange
            CalculaJurosRepository repo = new CalculaJurosRepository();
            var request = new CalculoJurosRequest(valorInicial, juros, meses);
            #endregion Arrange

            #region Act
            var result = repo.RetornaValorFinal(request);
            #endregion Act

            #region Assert
            Assert.Equal(result.ValorFinal, expected);
            #endregion Assert
        }
    }
}
