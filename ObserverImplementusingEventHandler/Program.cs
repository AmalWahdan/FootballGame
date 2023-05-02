// See https://aka.ms/new-console-template for more information



using ObserverImplementusingEventHandler.Investors;
using ObserverImplementusingEventHandler;

Stock ibm = new Stock("IBM", 120.00);
Investor investor1 = new Investor("Sorros");
Investor investor2 = new Investor("Berkshire");
ibm.PriceChanged += investor1.Update;
ibm.PriceChanged += investor2.Update;

ibm.Price = 120.10;
ibm.Price = 121.00;
ibm.Price = 120.50;
ibm.Price = 120.75;

//Console.ReadKey();