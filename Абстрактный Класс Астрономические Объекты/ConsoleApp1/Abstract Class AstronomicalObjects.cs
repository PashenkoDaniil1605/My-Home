using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AstronomicalObjects
    {
        public abstract string Move();
        public abstract string Size();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine($"Название объекта: {ShapeName()}\n" + $"Его размер: {Size()}\n" + $"Что оно делает: {Move()}");
            Console.WriteLine();
        }
    }
}
