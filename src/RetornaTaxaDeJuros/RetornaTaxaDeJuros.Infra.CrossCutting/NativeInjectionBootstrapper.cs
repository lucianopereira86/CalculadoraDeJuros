using Microsoft.Extensions.DependencyInjection;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using RetornaTaxaDeJuros.Infra.Repository.Repositories;

namespace RetornaTaxaDeJuros.Infra.CrossCutting
{
    public class NativeInjectionBootstrapper
    {
        public NativeInjectionBootstrapper(IServiceCollection services)
        {
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();
        }
    }
}
