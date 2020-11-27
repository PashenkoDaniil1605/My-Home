using System;
namespace ConsoleApp1
{
class DucksDontSwimm : ISwimm
    {
        public void Swimm()
        {
            Console.WriteLine("Я не умею плавать!");
        }
    }
}
