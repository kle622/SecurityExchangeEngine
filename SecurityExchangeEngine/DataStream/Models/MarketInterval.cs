using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityExchangeEngine
{
    public class MarketInterval : IMarketInterval
    {
        public int IntervalSeconds { get; }
        public IDictionary<ISecurity, IOrderedEnumerable<ISecurityInterval>> SymbolIntervals { get; }

        public MarketInterval(int intervalSeconds, IEnumerable<ISecurityInterval> symbolIntervals)
        {
            IntervalSeconds = intervalSeconds;
            SymbolIntervals = symbolIntervals.GroupBy(s => s.Security)
                .ToDictionary(g => g.Key, g => g.OrderBy(s => s.Date));
        }
    }
}
