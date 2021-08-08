namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class CalculoJurosResultVM
    {
        public CalculoJurosResultVM(double valorFinal)
        {
            ValorFinal = valorFinal;
        }
        public double ValorFinal { get; private set; }
    }
}
