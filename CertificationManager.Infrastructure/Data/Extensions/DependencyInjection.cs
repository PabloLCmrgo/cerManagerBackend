using CertificationManager.Infrastructure.Abstractions.Data;
using CertificationManager.Infrastructure.Data.DBContexts;
using CertificationManager.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using CertificationManager.Infrastructure.Abstractions.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CertificationManager.Infrastructure.Data.Extensions
{
    /*
    public class SGDObrasFactory : IDbContextFactory<SGDObrasContext>
    {
        public SGDObrasContext Create()
        {

            return new SGDObrasContext();
        }
    }*/
    public static class DependencyInjection
    {
        public static IServiceCollection AddInMemoryEntityFramework(this IServiceCollection services)
        {
            AddRepositories(services);
            //services.AddScoped<SGDObrasContext>(options => options.UseInMemoryDatabase(databaseName: "charger_tms"));
            return services;
        }

        public static IServiceCollection AddSqlEntityFramework(this IServiceCollection services, IConfiguration configuration)//, IConfiguration configuration
        {
            AddRepositories(services);
            //services.AddSingleton(new AzureAuthenticationInterceptor());

            services.AddPooledDbContextFactory<SGDObrasContext>((provider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ObrasConnection"));
            });


            services.AddScoped<SGDObrasContext>(
                sp => sp.GetRequiredService<IDbContextFactory<SGDObrasContext>>()
                .CreateDbContext());

            return services;
        }


        static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<ICertificacionesVolumenesRepository, CertificacionesVolumenesRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
