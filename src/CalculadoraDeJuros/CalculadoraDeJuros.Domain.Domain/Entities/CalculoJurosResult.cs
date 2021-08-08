namespace CalculadoraDeJuros.Domain.Domain.Entities
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
