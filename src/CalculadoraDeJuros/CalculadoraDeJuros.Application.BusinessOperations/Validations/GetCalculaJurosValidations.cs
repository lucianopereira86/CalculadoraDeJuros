using CalculadoraDeJuros.Application.BusinessOperations.Enum;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using FluentValidation;

namespace CalculadoraDeJuros.Application.BusinessOperations.Validations
{
    public class GetCalculaJurosValidations: AbstractValidator<GetCalculaJurosVM>
    {
        public GetCalculaJurosValidations()
        {
            RuleFor(r => r.ValorInicial)
                .GreaterThan(0)
                .WithErrorCode(((int)ErrorCode.VALORINICIAL_EMPTY).ToString())
                .WithMessage(ErrorCode.VALORINICIAL_EMPTY.ToString());

            RuleFor(r => r.Meses)
                .GreaterThan(0)
                .WithErrorCode(((int)ErrorCode.MESES_EMPTY).ToString())
                .WithMessage(ErrorCode.MESES_EMPTY.ToString());
        }
    }
}
