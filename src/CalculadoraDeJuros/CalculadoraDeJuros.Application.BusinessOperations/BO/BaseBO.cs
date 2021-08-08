using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using FluentValidation.Results;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace CalculadoraDeJuros.Application.BusinessOperations.BO
{
    public class BaseBO
    {
        protected void GetErrors(ValidationResult validationResult)
        {
            var errors = validationResult.Errors.Select(e => new ErrorVM(int.Parse(e.ErrorCode), e.ErrorMessage)).ToList();
            throw new Exception(JsonConvert.SerializeObject(errors));
        }
    }
}
