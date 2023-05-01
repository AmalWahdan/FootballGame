using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator
{
    public class Forward : PlayerRole
    {
       
        IPlayer player { get; set; }

        public int id { get; set; }
        public string name { get; set; }

        public void AssignPlayer(IPlayer player)
        {
            this.player = player;
        }

        public void ShootGoal() { Console.WriteLine("Forward Shoot Goal"); }
        public string PassBall() { return "Forward" + player.PassBall(); }
    }
}
