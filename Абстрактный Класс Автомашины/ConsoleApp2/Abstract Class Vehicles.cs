using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Vehicles
    {
        public abstract string Move();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine($"Название аппарата: {ShapeName()}\n" + $"Что он делает: {Move()}");
            Console.WriteLine();
        }
    }
}
