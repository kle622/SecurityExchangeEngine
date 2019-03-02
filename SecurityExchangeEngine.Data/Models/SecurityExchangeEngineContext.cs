using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine.Data
{
    public class SecurityExchangeEngineContext : DbContext
    {
        public SecurityExchangeEngineContext(DbContextOptions<SecurityExchangeEngineContext> options)
            : base(options)
        { }

        public DbSet<StockInterval> StockIntervals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedStockInterval(modelBuilder);
        }

        private void SeedStockInterval(ModelBuilder modelBuilder)
        {
            var id = 1;
            var seed = new StockInterval[]
            {
                new StockInterval
                {
                    Id = id++,
                    Exchange = "NYSE",
                    IntervalSeconds = 1,
                    TickerSymbol = "A",
                    Date = DateTime.Parse("01-Mar-2018 09:30"),
                    Open = 0,
                    High = 100,
                    Low = 0,
                    Close = 100,
                    Volume = 16487
                }
            };

            modelBuilder.Entity<StockInterval>().HasData(seed);
        }
    }
}
