namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class CalculoJurosResult
    {
        public CalculoJurosResult(double valorFinal)
        {
            ValorFinal = valorFinal;
        }
        public double ValorFinal { get; private set; }
    }
}
