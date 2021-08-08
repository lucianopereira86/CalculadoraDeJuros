using RetornaTaxaDeJuros.Domain.Domain.Interfaces;

namespace RetornaTaxaDeJuros.Infra.Repository.Repositories
{
    public class TaxaJurosRepository: ITaxaJurosRepository
    {
        public double GetTaxaJuros()
        {
            return 0.01;
        }
    }
}
