using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Entities;

namespace CalculadoraDeJuros.Application.BusinessOperations.Mapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CalculoJurosRequestVM, CalculoJuros>();
        }
    }
}
