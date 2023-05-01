// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using BuilderPattern.builders;

Director director = new Director();
IBuilder builderSingle = new BuilderSingle();
IBuilder builderMulti = new BuilderMulti();
director.ConstructGround(builderSingle);
Product groundSingle = builderSingle.GetGround();
groundSingle.display();
Console.WriteLine("--------------------------");
director.ConstructGround(builderMulti);
Product groundMulti = builderMulti.GetGround();
groundMulti.display();



