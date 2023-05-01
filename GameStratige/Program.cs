
using GameStratige;

Team team = new Team();
team.PlayGames();
Console.WriteLine("-------------------");
team.SetStrategy(new DefendStrategy());
team.PlayGames();
Console.WriteLine("-------------------");
