using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Infra.Repository.Repositories
{
    public class TaxaJurosRepository: ITaxaJurosRepository
    {
        public async Task<double> GetTaxaJuros()
        {
            await Task.Delay(1);
            return 0.01;
        }
    }
}
