using System;
namespace ConsoleApp1
{
class DucksDontGo : IGo
    {
        public void Go()
        {
            Console.WriteLine("Я не умею ходить!");
        }
    }
}
