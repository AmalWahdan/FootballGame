using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementusingEventHandler.Investors
{
    internal class StockEventArgs
    {
        private string _symbol;
        private double _price;

        public StockEventArgs(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public string Symbol { get { return _symbol; } }
        public double Price { get { return _price; } }
    }
}
