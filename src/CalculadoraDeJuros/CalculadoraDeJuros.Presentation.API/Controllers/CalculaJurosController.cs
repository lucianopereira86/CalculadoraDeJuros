using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Presentation.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ILogger<CalculaJurosController> _logger;
        private readonly ICalculaJurosBO _calculaJurosBO;

        public CalculaJurosController(ILogger<CalculaJurosController> logger, ICalculaJurosBO calculaJurosBO)
        {
            _logger = logger;
            _calculaJurosBO = calculaJurosBO;
        }

        [HttpGet]
        [Route("calculajuros")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetCalculaJuros([FromQuery] GetCalculaJurosVM request)
        {
            var result = await _calculaJurosBO.GetCalculaJuros(request);
            _logger.LogInformation($"GetCalculaJuros => ValorFinal = {result.ValorFinal}");
            return Ok(result);
        }
    }
}
