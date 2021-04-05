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
            AstronomicalObjects object1 = new Planet();
            object1.ShowInfo();

            AstronomicalObjects object2 = new Comet();
            object2.ShowInfo();

            AstronomicalObjects object3 = new Star();
            object3.ShowInfo();

            Console.ReadKey();
        }
    }
}
