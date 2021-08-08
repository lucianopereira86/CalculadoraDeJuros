using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeJuros.Infra.Repository.Repositories
{
    public class CalculaJurosRepository
    {
        public double RetornaValorFinal(double valorInicial, double juros, int meses)
        {
            return Math.Truncate((valorInicial * Math.Pow(1 + juros, meses)) * 100) / 100;
        }
    }
}
