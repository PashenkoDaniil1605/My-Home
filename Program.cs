using System;
namespace ConsoleApp1
{
class Program
    {
        static void Main(string[] args)
        {
            Duck ducks = new Duck();
            ducks.ShowGolos();
            WoodDuck woodduck = new WoodDuck();
            woodduck.ShowGolos();
            RuberDuck ruberduck = new RuberDuck();
            ruberduck.ShowGolos();
            TurkeyCock turkeyCock = new TurkeyCock();
            turkeyCock.ShowGolos();
            ADuck biduck = new AdapterTurkeyCock(turkeyCock);
            biduck.ShowGolos();
            Console.WriteLine("___________________");
            Console.WriteLine("Меню Уток (Массив):");
            Console.WriteLine("___________________");
            ADuck[] arr = { woodduck, ruberduck, biduck };
            QuantityDuck2 duckarray = new QuantityDuck2(arr);
            duckarray.OutPutDucks();
            Console.WriteLine("_________________");
            Console.WriteLine("Меню Уток (Лист):");
            Console.WriteLine("_________________");
            List<ADuck> list = new List<ADuck>();
            list.Add(woodduck);
            list.Add(ruberduck);
            list.Add(biduck);
            QuantityDuck duckList = new QuantityDuck(list);
            duckList.OutPutDucks();
            Console.ReadLine();
        }
    }
}
