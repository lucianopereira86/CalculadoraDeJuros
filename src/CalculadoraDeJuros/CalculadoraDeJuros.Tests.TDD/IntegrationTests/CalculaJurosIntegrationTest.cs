using System.Net.Http;
using System.Threading.Tasks;
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
        public async Task GetCalculaJuros()
        {
            var httpResponse = await _client.GetAsync("/api/calculaJuros");

            httpResponse.EnsureSuccessStatusCode();

            Assert.True(httpResponse.IsSuccessStatusCode);
        }
    }
}
