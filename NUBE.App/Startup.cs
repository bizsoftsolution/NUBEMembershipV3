using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;
using NUBE.App.Services;
using NUBE.BLL.IRepositories;
using NUBE.BLL.Repositories;

namespace NUBE.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Since Blazor is running on the server, we can use an application service
            // to read the forecast data.
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton<AppState>();

            services.AddTransient<IRelationShipRepository, RelationShipRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IPersonTitleRepository, PersonTitleRepository>();
            services.AddTransient<IOrganisationDetailRepository, OrganisationDetailRepository>();
            services.AddTransient<IOrganisationBranchDetailRepository, OrganisationBranchDetailRepository>();
            services.AddTransient<IBankRepository, BankRepository>();
            services.AddTransient<IBankBranchRepository, BankBranchRepository>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
