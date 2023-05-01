using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStratige
{
    internal class AttackStrategy : TeamStrategy
    {
        public override string play()
        {
            return "Attack **";
        }
    }
}
