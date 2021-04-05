using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine($"Название фигуры: {ShapeName()}\n" + $"Площадь: {Area()}\n" + $"Периметр: {Perimeter()}");
            Console.WriteLine();
        }
    }
}
