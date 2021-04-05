using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public abstract string Type();
        public abstract string Class();
        public abstract string ShapeName();

        public void ShowInfo()
        {
            Console.WriteLine($"Название животного: {ShapeName()}\n" + $"Его тип: {Type()}\n" + $"Его класс: {Class()}");
            Console.WriteLine();
        }
    }
}
