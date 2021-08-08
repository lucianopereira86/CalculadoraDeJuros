using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CalculadoraDeJuros.Infra.CrossCutting
{
    public static class NativeInjectionBootstrapper
    {
        public static IServiceCollection Injector(this IServiceCollection services)
        {
            #region Interfaces
            #endregion Interfaces

            #region AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(Application.BusinessOperations.Mapper.DomainToViewModeMappingProfile));
            #endregion AutoMapper

            return services;
        }
    }
}
