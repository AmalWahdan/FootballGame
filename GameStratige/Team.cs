using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStratige
{
    internal class Team
    {
        public TeamStrategy teamStrategy { get; set; } = new AttackStrategy();
        public void SetStrategy(TeamStrategy teamStrategy )
        {
            this.teamStrategy = teamStrategy;   
        }
        public void PlayGames()
        {
            Console.WriteLine(teamStrategy.play());
        }
    }
}
