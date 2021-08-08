using RetornaTaxaDeJuros.Domain.Domain.Entities;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Infra.Repository.Repositories
{
    public class TaxaJurosRepository: ITaxaJurosRepository
    {
        public async Task<Juros> GetTaxaJuros()
        {
            await Task.Delay(1);
            return new Juros { Taxa = 0.01 };
        }
    }
}
