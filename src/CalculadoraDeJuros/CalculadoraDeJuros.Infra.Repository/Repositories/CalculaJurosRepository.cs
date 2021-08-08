using CalculadoraDeJuros.Domain.Domain.Entities;
using System;

namespace CalculadoraDeJuros.Infra.Repository.Repositories
{
    public class CalculaJurosRepository
    {
        public CalculoJurosResult RetornaValorFinal(CalculoJurosRequest request)
        {
            double valorFinal = Math.Truncate((request.ValorInicial * Math.Pow(1 + request.Juros, request.Meses)) * 100) / 100;
            var result = new CalculoJurosResult(valorFinal);
            return result;
        }
    }
}
