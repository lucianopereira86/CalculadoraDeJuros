namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class ErrorVM
    {
        public ErrorVM(int errorCode, string errorMessage)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        public int ErrorCode { get; private set; }
        public string ErrorMessage { get; private set; }
    }
}
