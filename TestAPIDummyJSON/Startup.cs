using Microsoft.Extensions.DependencyInjection;
using TestAPIDummyJSON.Base;


namespace TestAPIDummyJSON
{
    public class Startup
    {
        // Creating all dependencies in one file automatically due to DI 
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<IRestLibrary, RestLibrary>()
                .AddScoped<IRestBuilder, RestBuilder>()
                .AddScoped<IRestFactory, RestFactory>();
        }
    }
}
