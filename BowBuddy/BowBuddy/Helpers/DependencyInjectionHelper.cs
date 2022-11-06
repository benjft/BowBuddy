using BowBuddy.Handlers;
using BowBuddy.Handlers.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BowBuddy.Helpers {
    public static class DependencyInjectionHelper {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) {
            services.AddSingleton<IDataProvider, DatabaseProvider>();
            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services) {
            return services;
        }
    }
}