using Microsoft.Extensions.DependencyInjection;
using Testing.Services.Interfaces;

namespace Testing.Services
{
    internal static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialog>();
    }
}
