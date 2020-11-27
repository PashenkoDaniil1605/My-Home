using System;
namespace ConsoleApp1
{
class TurkeyCock : ATurkeyCock
    {
        public TurkeyCock() : base(new DucksDontFly(), new TurkeyCockCluck(), new DucksWalkSwimm(), new DucksStopGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("____________________");
            Console.WriteLine("Это Обычный Индюк - ");
            Console.WriteLine("____________________");
            base.ShowGolos();
        }
    }
}
