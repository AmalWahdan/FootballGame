using ObserverImplementusingEventHandler.Investors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementusingEventHandler
{
    internal class Stock
    {

        private string _symbol;
        private double _price;

        public event EventHandler<StockEventArgs> PriceChanged;

       
        public Stock(string symbol, double price)
        {
            _symbol = symbol;
            _price = price;
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPriceChanged(new StockEventArgs(_symbol, _price));
                }
            }
        }

       
        protected virtual void OnPriceChanged(StockEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }


    }
}
