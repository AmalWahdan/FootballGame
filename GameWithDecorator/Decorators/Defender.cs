using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator
{
    public class Defender : PlayerRole
    {
        IPlayer player { get; set; }
       
        public int id { get ; set ; }
        public string name { get; set ; }

        public void AssignPlayer(IPlayer player)
        {
            this.player = player;
        }

        public void Defend()
        {Console.WriteLine("Defender Defend"); }
        public  string PassBall() { return "Defender" + player.PassBall(); }
        
    }
}
