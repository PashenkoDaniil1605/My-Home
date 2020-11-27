using System;
namespace ConsoleApp1
{
class RuberDuck : ADuck
    {
        public RuberDuck() : base(new DucksDontFly(), new DucksPisckQuack(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("_____________________");
            Console.WriteLine("Это Резиновая Утка - ");
            Console.WriteLine("_____________________");
            base.ShowGolos();
        }
    }
}
