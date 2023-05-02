using ObserverImplementusingEventHandler.Investors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementusingEventHandler
{
    internal interface IInvestor
    {
        void Update(object sender, StockEventArgs e);
    }

}
