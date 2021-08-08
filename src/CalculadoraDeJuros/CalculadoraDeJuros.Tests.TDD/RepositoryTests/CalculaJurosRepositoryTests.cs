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
            #endregion Arrange

            #region Act
            double valorFinal = Math.Truncate((valorInicial * Math.Pow(1 + juros, meses)) * 100) / 100;
            #endregion Act

            #region Assert
            Assert.Equal(valorFinal, expected);
            #endregion Assert
        }
    }
}
