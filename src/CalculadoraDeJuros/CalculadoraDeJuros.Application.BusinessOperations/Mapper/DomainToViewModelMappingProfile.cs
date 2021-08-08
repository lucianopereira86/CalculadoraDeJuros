using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Models;

namespace CalculadoraDeJuros.Application.BusinessOperations.Mapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CalculaJuros, GetCalculaJurosResultVM>();
        }
    }
}
