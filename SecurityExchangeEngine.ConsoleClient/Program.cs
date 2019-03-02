using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SecurityExchangeEngine.Data;
using System;
using System.IO;

namespace SecurityExchangeEngine.ConsoleClient
{
    internal static class Program
    {
        internal const string ASPNETCORE_ENVIRONMENT = "ASPNETCORE_ENVIRONMENT";
        internal const string SecurityExchangeEngineConnectionStringName = "SecurityExchangeEngine";
        private static string EnvironmentName;
        private static IConfigurationRoot Configuration;
        private static IServiceCollection Services;
        private static string SecurityExchangeEngineConnectionString;

        private static void Main(string[] args)
        {
            Configuration = BuildConfiguration();
            Services = BuildServices();
            SecurityExchangeEngineConnectionString = Configuration.GetConnectionString(SecurityExchangeEngineConnectionStringName);
        }

        internal static IServiceCollection BuildServices()
        {
            var services = new ServiceCollection();

            services.AddEntityFrameworkNpgsql()
                    .AddDbContext<SecurityExchangeEngineContext>
                        (optionsBuilder => optionsBuilder.UseNpgsql(SecurityExchangeEngineConnectionString))
                    .BuildServiceProvider();

            return services;
        }

        internal static IConfigurationRoot BuildConfiguration()
        {
            EnvironmentName = Environment.GetEnvironmentVariable(ASPNETCORE_ENVIRONMENT);
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.{EnvironmentName}.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
