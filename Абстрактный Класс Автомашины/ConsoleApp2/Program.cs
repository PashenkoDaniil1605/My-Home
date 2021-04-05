using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicles1 = new Car();
            vehicles1.ShowInfo();

            Vehicles vehicles2 = new PowerBoat();
            vehicles2.ShowInfo();

            Vehicles vehicles3 = new AirPlane();
            vehicles3.ShowInfo();

            Console.ReadKey();
        }
    }
}
