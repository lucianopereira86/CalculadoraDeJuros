using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.Interfaces
{
    public interface ICalculaJurosBO
    {
        Task<CalculoJurosResultVM> GetValorFinal(CalculoJurosRequestVM request);
    }
}
