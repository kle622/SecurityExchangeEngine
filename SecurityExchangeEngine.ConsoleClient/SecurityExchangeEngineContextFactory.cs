using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SecurityExchangeEngine.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine.ConsoleClient
{
    public class SecurityExchangeEngineContextFactory : IDesignTimeDbContextFactory<SecurityExchangeEngineContext>
    {
        public SecurityExchangeEngineContext CreateDbContext(string[] args)
        {
            var configuration = Program.BuildConfiguration();

            var optionsBuilder = new DbContextOptionsBuilder<SecurityExchangeEngineContext>()
                .UseNpgsql(configuration.GetConnectionString(Program.SecurityExchangeEngineConnectionStringName));

            return new SecurityExchangeEngineContext(optionsBuilder.Options);
        }
    }
}
