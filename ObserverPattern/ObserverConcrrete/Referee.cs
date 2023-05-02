using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverConcrrete
{
    internal class Referee:Observer
    {
        private Position ballPosition;

        public int Id { get; set; }
        public string Name { get; set; }
        public Referee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void update(Position position)
        {
            ballPosition = position;
            Console.WriteLine($"Refer {Name} Position:\n     ({ballPosition.x} ,{ballPosition.y},{ballPosition.z}) ");
        }
      
      
    }
}
