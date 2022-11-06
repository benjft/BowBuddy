using System;
using BowBuddy.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace BowBuddy {
    public static class Startup {
        public static IServiceProvider ServiceProvider { get; }

        static Startup() {
            ServiceProvider = new ServiceCollection()
                .ConfigureServices()
                .ConfigureViewModels()
                .BuildServiceProvider();
        }
    }
}