using RetornaTaxaDeJuros.Application.BusinessOperations.Models;
using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces
{
    public interface ITaxaJurosBO
    {
        Task<JurosVM> GetTaxaJuros();
    }
}
