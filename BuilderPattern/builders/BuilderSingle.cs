using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.builders
{
    internal class BuilderSingle : IBuilder
    {
        private Product product;

        public BuilderSingle()
        {
            product=new Product();
        }
        public void BuilderParts()
        {
            product.Add("Part from BuilderSingle");
        }

        public Product GetGround()
        {
            return product;
        }
    }
}
