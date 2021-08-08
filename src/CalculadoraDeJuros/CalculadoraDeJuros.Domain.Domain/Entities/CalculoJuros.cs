using System;

namespace CalculadoraDeJuros.Domain.Domain.Entities
{
    public class CalculoJuros
    {
        public CalculoJuros(double valorInicial, double juros, int meses)
        {
            ValorInicial = valorInicial;
            Juros = juros;
            Meses = meses;
        }

        public double ValorInicial { get; private set; }
        public double Juros { get; private set; }
        public int Meses { get; private set; }
        public double ValorFinal => Math.Truncate((ValorInicial * Math.Pow(1 + Juros, Meses)) * 100) / 100;
    }
}
