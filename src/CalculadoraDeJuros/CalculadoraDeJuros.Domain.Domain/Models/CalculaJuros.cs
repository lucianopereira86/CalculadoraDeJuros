using System;

namespace CalculadoraDeJuros.Domain.Domain.Models
{
    public class CalculaJuros
    {
        public CalculaJuros(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }

        public void SetJuros(double juros)
        {
            Juros = juros;
        }

        public double ValorInicial { get; private set; }
        public double Juros { get; private set; }
        public int Meses { get; private set; }
        public double ValorFinal => Math.Truncate((ValorInicial * Math.Pow(1 + Juros, Meses)) * 100) / 100;
    }
}
