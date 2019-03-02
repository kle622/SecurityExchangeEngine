using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityExchangeEngine
{
    public class MarketIntervalStream : IObservable<IMarketInterval>
    {
        private IObservable<IMarketInterval> _observable { get; }

        public MarketIntervalStream(IMarketIntervalFactory marketIntervalFactory)
        {
            _observable = Observable.FromAsync(marketIntervalFactory.GetNext);
        }

        public IDisposable Subscribe(IObserver<IMarketInterval> observer)
        {
            return _observable.Subscribe(observer);
        }
    }
}
