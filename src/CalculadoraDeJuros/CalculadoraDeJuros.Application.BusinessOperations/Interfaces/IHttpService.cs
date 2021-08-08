using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.Interfaces
{
    public interface IHttpService
    {
        Task<T> Connect<T>(string url, string method, dynamic obj = null);
    }
}
