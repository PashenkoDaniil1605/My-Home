using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Bear();
            animal1.ShowInfo();

            Animal animal2 = new Fish();
            animal2.ShowInfo();

            Animal animal3 = new Spider();
            animal3.ShowInfo();

            Console.ReadKey();
        }
    }
}
