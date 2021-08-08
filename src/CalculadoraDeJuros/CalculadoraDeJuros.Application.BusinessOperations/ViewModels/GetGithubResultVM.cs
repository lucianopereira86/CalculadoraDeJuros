namespace CalculadoraDeJuros.Application.BusinessOperations.ViewModels
{
    public class GetGitHubResultVM
    {
        public GetGitHubResultVM(string url)
        {
            Url = url;
        }

        public string Url { get; private set; }
    }
}
