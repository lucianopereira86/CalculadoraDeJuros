namespace CalculadoraDeJuros.Domain.Domain.Models
{
    public class Juros
    {
        public Juros(double taxa)
        {
            Taxa = taxa;
        }

        public double Taxa { get; private set; }
    }
}
