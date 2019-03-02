using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine
{
    public interface ISecurityInterval : ISecurityPrice
    {
        decimal Open { get; }
        decimal High { get; }
        decimal Low { get; }
        decimal Close { get; }
        int Volume { get; }
    }
}
