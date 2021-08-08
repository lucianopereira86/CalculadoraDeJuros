using AutoMapper;
using RetornaTaxaDeJuros.Application.BusinessOperations.Models;
using RetornaTaxaDeJuros.Domain.Domain.Entities;

namespace RetornaTaxaDeJuros.Application.BusinessOperations.Mapper
{
    public class DomainToViewModeMapping: Profile
    {
        public DomainToViewModeMapping()
        {
            CreateMap<Juros, JurosVM>();
        }
    }
}
