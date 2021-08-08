using RetornaTaxaDeJuros.Domain.Domain.Entities;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Domain.Domain.Interfaces
{
    public interface ITaxaJurosRepository
    {
        Task<Juros> GetTaxaJuros();
    }
}
