using System;
namespace ConsoleApp1
{
class DucksDontFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
 }
