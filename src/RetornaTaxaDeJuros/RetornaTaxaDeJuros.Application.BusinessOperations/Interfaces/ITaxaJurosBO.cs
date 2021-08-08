using System.Threading.Tasks;

namespace RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces
{
    public interface ITaxaJurosBO
    {
        Task<double> GetTaxaJuros();
    }
}
