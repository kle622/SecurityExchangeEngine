using System;

namespace SecurityExchangeEngine
{
    public class SecurityInterval : ISecurityInterval
    {
        public ISecurity Security { get; }
        public DateTime Date { get; }
        public decimal Open { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public decimal Close { get; }
        public decimal Price => Close;
        public int Volume { get; }
        

        public SecurityInterval(
            ISecurity security,
            DateTime date,
            decimal open,
            decimal high,
            decimal low,
            decimal close,
            int volume)
        {
            Security = security;
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }
    }
}