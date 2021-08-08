using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces;
using RetornaTaxaDeJuros.Application.BusinessOperations.Models;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Presentation.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;
        private readonly ITaxaJurosBO _taxaJurosBO;

        public TaxaJurosController(ILogger<TaxaJurosController> logger, ITaxaJurosBO taxaJurosBO)
        {
            _logger = logger;
            _taxaJurosBO = taxaJurosBO;
        }

        [HttpGet]
        [Route("taxaJuros")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get()
        {
            JurosVM juros = await _taxaJurosBO.GetTaxaJuros();
            _logger.LogInformation($"GetTaxaJuros => Juros.Taxa = {juros.Taxa}");
            return Ok(juros);
        }
    }
}
