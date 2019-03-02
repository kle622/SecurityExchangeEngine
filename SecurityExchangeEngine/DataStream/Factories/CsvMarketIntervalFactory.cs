using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExchangeEngine
{
    public class CsvMarketIntervalFactory : IMarketIntervalFactory
    {
        public Task<IMarketInterval> GetNext()
        {
            throw new NotImplementedException();
        }
    }
}
