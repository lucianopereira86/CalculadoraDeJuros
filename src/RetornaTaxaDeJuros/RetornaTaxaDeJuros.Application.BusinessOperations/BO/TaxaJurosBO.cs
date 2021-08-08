using RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Application.BusinessOperations.BO
{
    public class TaxaJurosBO: ITaxaJurosBO
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;

        public TaxaJurosBO(ITaxaJurosRepository taxaJurosRepository)
        {
            _taxaJurosRepository = taxaJurosRepository;
        }

        public async Task<double> GetTaxaJuros ()
        {
            return await _taxaJurosRepository.GetTaxaJuros();
        }
    }
}
