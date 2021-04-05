using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Triangle(4, 5, 6);
            figure1.ShowInfo();

            Figure figure2 = new Acircle(2, 6);
            figure2.ShowInfo();

            Figure figure3 = new Rectangle(5, 6);
            figure3.ShowInfo();

            Console.ReadKey();
        }
    }
}
