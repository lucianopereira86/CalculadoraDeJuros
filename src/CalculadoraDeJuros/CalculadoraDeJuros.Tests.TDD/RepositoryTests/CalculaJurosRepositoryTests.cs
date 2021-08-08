using CalculadoraDeJuros.Infra.Repository.Repositories;
using System;
using Xunit;

namespace CalculadoraDeJuros.Tests.RepositoryTests
{
    public class CalculaJurosRepositoryTests
    {
        [Theory]
        [InlineData(100.0, 5, 105.10)]
        public void ShouldReturnSuccessWhenEqualsExpected(double valorInicial, int meses, double expected)
        {
            #region Arrange
            double juros = 0.01;
            CalculaJurosRepository repo = new CalculaJurosRepository();
            #endregion Arrange

            #region Act
            double valorFinal = repo.RetornaValorFinal(valorInicial, juros, meses);
            #endregion Act

            #region Assert
            Assert.Equal(valorFinal, expected);
            #endregion Assert
        }
    }
}
