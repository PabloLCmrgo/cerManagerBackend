using CertificationManager.Core.Abstractions.Services;
using CertificationManager.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CertificationManager.Core.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            AddStateMachineFlows(services);
            services.AddScoped<ICertificacionesVolumenesService, CertificacionesVolumenesService>();
            return services;
        }

        private static IServiceCollection AddStateMachineFlows(this IServiceCollection services)
        {
            //services.AddScoped<ITripEventDeleteStateMachineFlow, TripEventDeleteStateMachineFlow>();
            return services;
        }
    }
}
