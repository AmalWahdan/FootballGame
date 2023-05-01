using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithDecorator
{
    public  interface PlayerRole:IPlayer
    {
       

        public int id { get ; set; }
        public string name { get ; set ; }

        public string PassBall();

        public void AssignPlayer(IPlayer player);
       
      
    }
}
