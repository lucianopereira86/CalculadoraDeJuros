using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Xunit;

namespace CalculadoraDeJuros.Tests.IntegrationTests
{
    public class CalculaJurosIntegrationTest : IClassFixture<MyWebFactory>
    {
        private readonly HttpClient _client;

        public CalculaJurosIntegrationTest(MyWebFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ShouldReturnSuccessWhenResultEqualsExpected()
        {
            #region Arrange
            var request = new GetCalculaJurosVM { ValorInicial = 100.0, Meses = 5 };
            var expectedResult = new GetCalculaJurosResultVM { ValorFinal = 105.10 };

            string uri = $"/api/calculaJuros?{GetQueryString(request)}";
            #endregion Arrange

            #region Act
            var httpResponse = await _client.GetAsync(uri);
            #endregion Act

            #region Assert
            httpResponse.EnsureSuccessStatusCode();
            Assert.True(httpResponse.IsSuccessStatusCode);

            var result = JsonConvert.DeserializeObject<GetCalculaJurosResultVM>(httpResponse.Content.ReadAsStringAsync().Result);
            Assert.Equal(expectedResult.ValorFinal, result.ValorFinal);
            #endregion Assert
        }

        private string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString().Replace(",","."));

            return String.Join("&", properties.ToArray());
        }
    }
}
