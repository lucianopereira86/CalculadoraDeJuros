using AutoMapper;
using CalculadoraDeJuros.Application.BusinessOperations.BO;
using CalculadoraDeJuros.Application.BusinessOperations.Mapper;
using CalculadoraDeJuros.Application.BusinessOperations.ViewModels;
using CalculadoraDeJuros.Domain.Domain.Entities;
using System.Threading.Tasks;
using Xunit;

namespace CalculadoraDeJuros.Tests.BOTests
{
    public class CalculaJurosBOTests
    {
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

            var request = new CalculoJurosRequestVM { ValorInicial = valorInicial, Juros = juros, Meses = meses };
            var calculaJurosBO = new CalculaJurosBO(mapper);
            #endregion Arrange
            
            #region Act
            var result = await calculaJurosBO.GetValorFinal(request);
            #endregion Act

            #region Assert
            Assert.Equal(result.ValorFinal, expected);
            #endregion Assert
        }
    }
}
