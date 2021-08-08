using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Domain.Domain.Interfaces
{
    public interface ITaxaJurosRepository
    {
        Task<double> GetTaxaJuros();
    }
}
