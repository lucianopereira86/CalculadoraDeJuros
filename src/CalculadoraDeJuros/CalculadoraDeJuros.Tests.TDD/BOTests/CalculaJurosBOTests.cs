using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.BO;
using CalculadoraDeJuros.Application.BusinessOperations.Interfaces;
using CalculadoraDeJuros.Application.BusinessOperations.Mapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Models;
using CalculadoraDeJuros.Tests.IntegrationTests;
using FluentValidation;
using Microsoft.Extensions.Options;
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

        #region Private Methods
        private CalculaJurosBO InitCalculaJurosBO()
        {
            #region AutoMapper
            var domainToViewModelMappingProfile = new DomainToViewModelMappingProfile();
            var viewModelToDomainMappingProfile = new ViewModelToDomainMappingProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfiles(new Profile[] { domainToViewModelMappingProfile, viewModelToDomainMappingProfile }));
            IMapper mapper = new Mapper(configuration);
            #endregion AutoMapper

            #region Dependencies
            IValidator<GetCalculaJurosVM> validator = (IValidator<GetCalculaJurosVM>)_serviceProvider.GetService(typeof(IValidator<GetCalculaJurosVM>));
            IHttpService httpService = (IHttpService)_serviceProvider.GetService(typeof(IHttpService));
            IOptions<ConnectionStrings> options = (IOptions<ConnectionStrings>)_serviceProvider.GetService(typeof(IOptions<ConnectionStrings>));
            #endregion Dependencies

            return new CalculaJurosBO(mapper, validator, httpService, options);
        }
        #endregion Private Methods

        [Theory]
        [InlineData(100.0, 5, 105.10)]
        public async Task ShouldReturnSuccessWhenCalculaJurosValorFinalEqualsExpected(double valorInicial, int meses, double expected)
        {
            #region Arrange
            CalculaJurosBO calculaJurosBO = InitCalculaJurosBO();
            GetCalculaJurosVM request = new() { ValorInicial = valorInicial, Meses = meses };
            #endregion Arrange

            #region Act
            var result = await calculaJurosBO.GetCalculaJuros(request);
            #endregion Act

            #region Assert
            Assert.Equal(result.ValorFinal, expected);
            #endregion Assert
        }

        [Fact]
        public async Task ShouldReturnSuccessWhenGitHubUrlExists()
        {
            #region Arrange
            CalculaJurosBO calculaJurosBO = InitCalculaJurosBO();
            #endregion Arrange

            #region Act
            var result = await calculaJurosBO.GetGitHub();
            #endregion Act

            #region Assert
            Assert.NotEmpty(result.Url);
            #endregion Assert
        }
    }
}
