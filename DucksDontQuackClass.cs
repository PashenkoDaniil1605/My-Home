using System;
namespace ConsoleApp1
{
class DucksDontQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я не умею крякать!");
        }
    }
}
