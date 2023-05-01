using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator
{
    public class MidedFielder : PlayerRole
    {
        IPlayer player { get; set; }

        public int id { get; set; }
        public string name { get; set; }

        public void AssignPlayer(IPlayer player)
        {
            this.player = player;
        }

        public void Dribbe() { Console.WriteLine("MidFilder  Dribble  Ball"); }
        public string PassBall() { return "MidFilder" + player.PassBall(); }
    }
}
