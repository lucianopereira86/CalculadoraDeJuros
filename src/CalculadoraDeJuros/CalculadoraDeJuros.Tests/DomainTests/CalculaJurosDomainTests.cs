using CalculadoraDeJuros.Domain.Domain.Models;
using Xunit;

namespace CalculadoraDeJuros.Tests.BOTests
{
    public class CalculaJurosDomainTests
    {
        [Theory]
        [InlineData(100.0, 5, 0.01, 105.10)]
        public void ShouldReturnSuccessWhenValorFinalEqualsExpected(double valorInicial, int meses, double juros, double expected)
        {
            #region Act
            var result = new CalculaJuros(valorInicial,meses);
            result.SetTaxaJuros(juros);
            #endregion Act

            #region Assert
            Assert.Equal(result.ValorFinal, expected);
            #endregion Assert
        }
    }
}
