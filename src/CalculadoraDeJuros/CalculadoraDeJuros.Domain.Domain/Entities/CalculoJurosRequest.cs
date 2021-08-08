namespace CalculadoraDeJuros.Domain.Domain.Entities
{
    public class CalculoJurosRequest
    {
        public CalculoJurosRequest(double valorInicial, double juros, int meses)
        {
            ValorInicial = valorInicial;
            Juros = juros;
            Meses = meses;
        }

        public double ValorInicial { get; private set; }
        public double Juros { get; private set; }
        public int Meses { get; private set; }
    }
}
