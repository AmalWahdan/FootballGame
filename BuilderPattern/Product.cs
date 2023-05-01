namespace BuilderPattern
{
    internal class Product
    {
        public List<string> parts { get; set; }
        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void display()
        {

            Console.WriteLine("Product Component are:");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }

    }
}
