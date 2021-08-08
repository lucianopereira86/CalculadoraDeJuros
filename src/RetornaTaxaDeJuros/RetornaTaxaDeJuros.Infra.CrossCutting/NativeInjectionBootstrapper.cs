using Microsoft.Extensions.DependencyInjection;
using RetornaTaxaDeJuros.Application.BusinessOperations.BO;
using RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using RetornaTaxaDeJuros.Infra.Repository.Repositories;

namespace RetornaTaxaDeJuros.Infra.CrossCutting
{
    public class NativeInjectionBootstrapper
    {
        public NativeInjectionBootstrapper(IServiceCollection services)
        {
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();
            services.AddScoped<ITaxaJurosBO, TaxaJurosBO>();
        }
    }
}
