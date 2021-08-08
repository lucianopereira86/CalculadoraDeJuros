using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Entities;
using FluentValidation;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.BO
{
    public class CalculaJurosBO: BaseBO, ICalculaJurosBO
    {
        private readonly IMapper _mapper;
        private readonly IValidator<GetCalculaJurosVM> _validator;

        public CalculaJurosBO(IMapper mapper, IValidator<GetCalculaJurosVM> validator)
        {
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<GetCalculaJurosResultVM> GetCalculaJuros(GetCalculaJurosVM request)
        {
            await Task.Delay(1);
            var validationResult = await _validator.ValidateAsync(request);
            if(!validationResult.IsValid)
            {
                GetErrors(validationResult);
            }
            var calculaJuros = _mapper.Map<CalculaJuros>(request);
            var result = _mapper.Map<GetCalculaJurosResultVM>(calculaJuros);
            return result;
        }
    }
}
