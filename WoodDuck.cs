using System;
namespace ConsoleApp1
{
class WoodDuck : ADuck
    {
        public WoodDuck() : base(new DucksDontFly(), new DucksDontQuack(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("______________________");
            Console.WriteLine("Это Деревянная Утка - ");
            Console.WriteLine("______________________");
            base.ShowGolos();
        }
    }
}
