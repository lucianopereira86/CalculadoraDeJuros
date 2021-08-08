using AutoMapper;
using RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces;
using RetornaTaxaDeJuros.Application.BusinessOperations.Models;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Application.BusinessOperations.BO
{
    public class TaxaJurosBO: ITaxaJurosBO
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;
        private readonly IMapper _mapper;

        public TaxaJurosBO(ITaxaJurosRepository taxaJurosRepository, IMapper mapper)
        {
            _taxaJurosRepository = taxaJurosRepository;
            _mapper = mapper;
        }

        public async Task<JurosVM> GetTaxaJuros ()
        {
            var juros = await _taxaJurosRepository.GetTaxaJuros();
            var jurosVM = _mapper.Map<JurosVM>(juros);
            return jurosVM;
        }
    }
}
