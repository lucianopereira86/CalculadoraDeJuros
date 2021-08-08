using AutoMapper;
using RetornaTaxaDeJuros.Application.BusinessOperations.BO;
using RetornaTaxaDeJuros.Application.BusinessOperations.Mapper;
using RetornaTaxaDeJuros.Application.BusinessOperations.Models;
using RetornaTaxaDeJuros.Domain.Domain.Interfaces;
using RetornaTaxaDeJuros.Infra.Repository.Repositories;
using System.Threading.Tasks;
using Xunit;

namespace RetornaTaxaDeJuros.Tests.BOTests
{
    public class TaxaJurosBOTest
    {
        [Fact]
        public async Task ReturnSuccessWhenTaxaJurosEqualsToExpected()
        {
            #region Arrange
            double expected = 0.01;
            ITaxaJurosRepository taxaJurosRepository = new TaxaJurosRepository();
            
            var mappingProfile = new DomainToViewModeMappingProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            IMapper mapper = new Mapper(configuration);

            TaxaJurosBO taxaJurosBO = new TaxaJurosBO(taxaJurosRepository, mapper);
            #endregion Arrange

            #region Act
            JurosVM juros = await taxaJurosBO.GetTaxaJuros();
            #endregion Act

            #region Assert
            Assert.Equal(juros.Taxa, expected);
            #endregion Assert
        }
    }
}
