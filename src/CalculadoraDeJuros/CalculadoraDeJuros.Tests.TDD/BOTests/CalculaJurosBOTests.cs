using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.BO;
using CalculadoraDeJuros.Application.BusinessOperations.Mapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Entities;
using CalculadoraDeJuros.Tests.IntegrationTests;
using FluentValidation;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CalculadoraDeJuros.Tests.BOTests
{
    public class CalculaJurosBOTests : IClassFixture<MyWebFactory>
    {
        private readonly IServiceProvider _serviceProvider;

        public CalculaJurosBOTests(MyWebFactory factory)
        {
            _serviceProvider = factory.Services;
        }
        [Theory]
        [InlineData(100.0, 5, 0.01, 105.10)]
        public async Task ShouldReturnSuccessWhenValorFinalEqualsExpected(double valorInicial, int meses, double juros, double expected)
        {
            #region Arrange

            #region AutoMapper
            var domainToViewModelMappingProfile = new DomainToViewModelMappingProfile();
            var viewModelToDomainMappingProfile = new ViewModelToDomainMappingProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfiles(new Profile[] { domainToViewModelMappingProfile, viewModelToDomainMappingProfile }));
            IMapper mapper = new Mapper(configuration);
            #endregion AutoMapper

            #region Validator
            IValidator<GetCalculaJurosVM> validator = (IValidator<GetCalculaJurosVM>)_serviceProvider.GetService(typeof(IValidator<GetCalculaJurosVM>));
            #endregion Validator

            var request = new GetCalculaJurosVM { ValorInicial = valorInicial, Juros = juros, Meses = meses };
            var calculaJurosBO = new CalculaJurosBO(mapper, validator);
            #endregion Arrange

            #region Act
            var result = await calculaJurosBO.GetCalculaJuros(request);
            #endregion Act

            #region Assert
            Assert.Equal(result.ValorFinal, expected);
            #endregion Assert
        }
    }
}
