using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RetornaTaxaDeJuros.Tests.IntegrationTests
{
    public class TaxaJurosIntegrationTest : IClassFixture<MyWebFactory>
    {
        private readonly HttpClient _client;

        public TaxaJurosIntegrationTest(MyWebFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetTaxaJuros()
        {
            var httpResponse = await _client.GetAsync("/api/taxaJuros");

            httpResponse.EnsureSuccessStatusCode();

            Assert.True(httpResponse.IsSuccessStatusCode);
        }
    }
}
