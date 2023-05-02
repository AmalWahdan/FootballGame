using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImplementusingEventHandler.Investors
{
    internal class Investor
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(object sender, StockEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", _name, e.Symbol, e.Price);
        }


    }
}
