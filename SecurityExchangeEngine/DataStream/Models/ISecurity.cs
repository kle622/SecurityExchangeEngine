using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityExchangeEngine
{
    public interface ISecurity
    {
        string Exchange { get; }
        string Identifier { get; }
    }
}
