using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Test : ICloneable
    {
        public X f;
        public int b;
        public Test(int x, int y)
        {
            f = new X(x);
            b = y;
        }
        public void Show(string name)
        {
            Console.Write("Значения объекта " + name + ":");
            Console.WriteLine("Элемент f.a: {0}, Элемент b: {1}", f.a, b);
        }
        public object Clone()
        {
            Test temp = new Test(f.a, b);
            return temp;
        }
    }
}
