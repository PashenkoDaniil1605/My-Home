using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            int i = 123;
            object o = i; 
            i = (int)o; 
            Console.WriteLine(i);
            sWatch.Stop();
            Console.WriteLine(sWatch.ElapsedMilliseconds.ToString());
            Console.ReadLine();
        }
    }
}
