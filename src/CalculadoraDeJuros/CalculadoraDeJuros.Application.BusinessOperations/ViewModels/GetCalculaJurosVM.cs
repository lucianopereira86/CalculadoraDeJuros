using System.ComponentModel.DataAnnotations;

namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class GetCalculaJurosVM
    {
        [Required]
        public double ValorInicial { get; set; }
        [Required]
        public int Meses { get; set; }
    }
}
