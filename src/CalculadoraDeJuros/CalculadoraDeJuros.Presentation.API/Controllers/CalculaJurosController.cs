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

        public CalculaJurosController(ILogger<CalculaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("calculajuros")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
