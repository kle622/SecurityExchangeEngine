using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityExchangeEngine
{
    public interface IMarketInterval
    {
        int IntervalSeconds { get; }
        IDictionary<ISecurity, IOrderedEnumerable<ISecurityInterval>> SymbolIntervals { get; }
    }
}
