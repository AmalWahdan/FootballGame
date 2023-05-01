using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator.Players
{
    internal class FieldPlayer:IPlayer
    {
        public int id { get; set; }
        public string name { get; set; }
        public FieldPlayer(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public string PassBall()
        {
           return "FieldPlayer is Pass Ball";
        }

       
    }
}
