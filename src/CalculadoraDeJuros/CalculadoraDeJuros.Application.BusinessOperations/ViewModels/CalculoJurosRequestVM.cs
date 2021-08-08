namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class CalculoJurosRequestVM
    {
        public CalculoJurosRequestVM(double valorInicial, double juros, int meses)
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
