using GameWithDecorator;
using GameWithDecorator.Players;

namespace FootballGame
{

    public class Program
    {

        static void Main(string[] args)
        {

            IPlayer player = new FieldPlayer(1,"Ali");
            PlayerRole role = new  Forward();
            Console.WriteLine(player.PassBall());
            Console.WriteLine("----------------------------");
            role.AssignPlayer(player);
            player = role;
            Console.WriteLine(player.PassBall());
            Console.WriteLine("----------------------------");
            role = new Defender();
            role.AssignPlayer(player);
            player = role;
            Console.WriteLine(player.PassBall());
            Console.WriteLine("----------------------------");
            role = new MidedFielder();
            role.AssignPlayer(player);
            player = role;
            Console.WriteLine(player.PassBall());


        }

    }  


}