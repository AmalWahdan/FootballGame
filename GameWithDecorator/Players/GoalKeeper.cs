using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator.Players
{
    public class GoalKeeper : IPlayer
    {
        public int id { get; set; }
        public string name { get; set; }
        public GoalKeeper(int id, string name)
        {
            this.id = id;
            this.name = name;

        }

        public string PassBall()
        {
           return $"GoalKeeper is Pass Ball";
        }

       
    }
}
