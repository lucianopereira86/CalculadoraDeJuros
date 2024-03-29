﻿using CalculadoraDeJuros.Application.BusinessOperations.BO;
using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using CalculadoraDeJuros.Application.BusinessOperations.Validations;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Infra.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CalculadoraDeJuros.Infra.CrossCutting
{
    public static class NativeInjectionBootstrapper
    {
        public static IServiceCollection Injector(this IServiceCollection services)
        {
            #region Interfaces
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<ICalculaJurosBO, CalculaJurosBO>();
            services.AddScoped<IValidator<GetCalculaJurosVM>, GetCalculaJurosValidations>();
            #endregion Interfaces

            #region AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(Application.BusinessOperations.Mapper.DomainToViewModelMappingProfile));
            #endregion AutoMapper


            return services;
        }
    }
}
