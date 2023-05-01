
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStratige
{
    internal class DefendStrategy : TeamStrategy
    {
        public override string play()
        {
            return "Defend **";
        }
    }
}
