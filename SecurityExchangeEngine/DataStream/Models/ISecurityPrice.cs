using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine
{
    public interface ISecurityPrice
    {
        ISecurity Security { get; }
        decimal Price { get; }
        DateTime Date { get; }
    }
}
