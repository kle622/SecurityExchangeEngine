using System;
using System.ComponentModel.DataAnnotations;

namespace SecurityExchangeEngine.Data
{
    public class StockInterval
    {
        public int Id { get; set; }
        public string Exchange { get; set; }
        public int IntervalSeconds { get; set; }
        public string TickerSymbol { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
    }
}