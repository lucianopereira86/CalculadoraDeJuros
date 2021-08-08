using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CalculadoraDeJuros.Infra.CrossCutting;
using CalculadoraDeJuros.Presentation.API;
using CalculadoraDeJuros.Domain.Domain.Models;

namespace CalculadoraDeJuros.Tests.IntegrationTests
{
    public class TestStartup
    {
        public TestStartup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddApplicationPart(typeof(Startup).Assembly);
            // Dependency Injection
            NativeInjectionBootstrapper.Injector(services);
            services.Configure<ConnectionStrings>(x => Configuration.Bind("ConnectionStrings", x));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
