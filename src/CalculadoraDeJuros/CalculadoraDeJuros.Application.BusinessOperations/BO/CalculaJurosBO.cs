using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Entities;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.BO
{
    public class CalculaJurosBO
    {
        private readonly IMapper _mapper;
        public CalculaJurosBO(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<CalculoJurosResultVM> GetValorFinal(CalculoJurosRequestVM request)
        {
            var calculoJuros = _mapper.Map<CalculoJuros>(request);
            await Task.Delay(1);
            var result = _mapper.Map<CalculoJurosResultVM>(calculoJuros);
            return result;
        }
    }
}
