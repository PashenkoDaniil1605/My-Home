using System;
namespace ConsoleApp1
{
class Duck : ADuck
    {
        public Duck() : base(new DucksFly(), new DucksQuack(), new DucksSwimm(), new DucksGo())
        {

        }
        public override void ShowGolos()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("Это Обычная Утка - ");
            Console.WriteLine("___________________");
            base.ShowGolos();
        }

    }
}
