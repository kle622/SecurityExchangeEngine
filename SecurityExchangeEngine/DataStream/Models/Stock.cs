using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine
{
    public class Stock : ISecurity
    {
        public string Exchange { get; }
        public string TickerSymbol { get; }
        public string Identifier => TickerSymbol;
    }
}
