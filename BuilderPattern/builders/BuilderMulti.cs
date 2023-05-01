using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.builders
{
    internal class BuilderMulti : IBuilder
    {
        private Product product;

        public BuilderMulti()
        {
            product = new Product();
        }
        public void BuilderParts()
        {
            product.Add("Part from BuilderMulti");
        }

        public Product GetGround()
        {
            return product;
        }
    }
}
