using CalculadoraDeJuros.Application.BusinessOperations.BO;
using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CalculadoraDeJuros.Infra.CrossCutting
{
    public static class NativeInjectionBootstrapper
    {
        public static IServiceCollection Injector(this IServiceCollection services)
        {
            #region Interfaces
            services.AddScoped<ICalculaJurosBO, CalculaJurosBO>();
            #endregion Interfaces

            #region AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(Application.BusinessOperations.Mapper.DomainToViewModelMappingProfile));
            #endregion AutoMapper

            return services;
        }
    }
}
