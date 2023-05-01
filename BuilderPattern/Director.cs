using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Director
    {
        IBuilder? builder;
        public void ConstructGround(IBuilder builder)
        {
            this.builder = builder;
            builder.BuilderParts();
 
        }
    }
}
