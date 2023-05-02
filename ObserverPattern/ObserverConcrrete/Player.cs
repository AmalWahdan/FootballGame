using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverConcrrete
{
    internal class Player : Observer
    {
        private Position ballPosition;
        public int Id { get; set; }
        public string Name { get; set; }
        public Player(int id , string name)
        {
            Id = id;
            Name = name;
        }
        public void update(Position position)
        {
            ballPosition = position;
            Console.WriteLine($"Player {Name} Position:\n     ({ballPosition.x} ,{ballPosition.y},{ballPosition.z}) ");
            Console.WriteLine("----------------------");
        }
       
    }
}
