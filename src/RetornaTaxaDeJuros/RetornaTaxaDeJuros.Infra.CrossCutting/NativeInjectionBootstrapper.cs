using Microsoft.Extensions.DependencyInjection;
using RetornaTaxaDeJuros.Application.BusinessOperations.BO;
using RetornaTaxaDeJuros.Application.BusinessOperations.Interfaces;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using RetornaTaxaDeJuros.Infra.Repository.Repositories;
using System.Reflection;

namespace RetornaTaxaDeJuros.Infra.CrossCutting
{
    public static class NativeInjectionBootstrapper
    {
        public static IServiceCollection Injector(this IServiceCollection services)
        {
            #region Interfaces
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();
            services.AddScoped<ITaxaJurosBO, TaxaJurosBO>();
            #endregion Interfaces

            #region AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(Application.BusinessOperations.Mapper.DomainToViewModeMapping));
            #endregion AutoMapper

            return services;
        }
    }
}
