using Microsoft.Extensions.DependencyInjection;

namespace BowBuddy.Helpers {
    public static class DependencyInjectionHelper {
        public static IServiceCollection ConfigureServices(this IServiceCollection services) {
            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services) {
            return services;
        }
    }
}