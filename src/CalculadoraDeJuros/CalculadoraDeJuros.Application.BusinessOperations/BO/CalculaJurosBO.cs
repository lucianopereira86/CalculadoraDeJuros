using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.BO
{
    public class CalculaJurosBO: BaseBO, ICalculaJurosBO
    {
        private readonly IMapper _mapper;
        private readonly IHttpService _httpService;
        private readonly IValidator<GetCalculaJurosVM> _validator;
        private readonly ConnectionStrings _connectionStrings;

        public CalculaJurosBO(IMapper mapper, IValidator<GetCalculaJurosVM> validator, 
            IHttpService httpService, IOptions<ConnectionStrings> options)
        {
            _mapper = mapper;
            _validator = validator;
            _httpService = httpService;
            _connectionStrings = options.Value;
        }
        public async Task<GetCalculaJurosResultVM> GetCalculaJuros(GetCalculaJurosVM request)
        {
            await Task.Delay(1);
            var validationResult = await _validator.ValidateAsync(request);
            if(!validationResult.IsValid)
            {
                GetErrors(validationResult);
            }

            var httpResult = await _httpService.Connect(_connectionStrings.ApiTaxaJuros, "GET");
            var juros = Convert.ChangeType(httpResult, typeof(Juros));

            var calculaJuros = _mapper.Map<CalculaJuros>(request);
            calculaJuros.SetJuros(juros);
            var result = _mapper.Map<GetCalculaJurosResultVM>(calculaJuros);
            return result;
        }
    }
}
