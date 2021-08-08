using System.Threading.Tasks;

namespace CalculadoraDeJuros.Application.BusinessOperations.Interfaces
{
    public interface IHttpService
    {
        Task<dynamic> Connect(string url, string method, dynamic obj = null);
    }
}
