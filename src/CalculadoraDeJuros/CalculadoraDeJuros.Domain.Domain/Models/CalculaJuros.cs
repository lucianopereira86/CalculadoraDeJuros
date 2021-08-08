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

        public void SetTaxaJuros(double taxaJuros)
        {
            TaxaJuros = taxaJuros;
        }

        public double ValorInicial { get; private set; }
        public double TaxaJuros { get; private set; }
        public int Meses { get; private set; }
        public double ValorFinal => Math.Truncate((ValorInicial * Math.Pow(1 + TaxaJuros, Meses)) * 100) / 100;
    }
}
