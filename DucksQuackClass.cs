using System;
namespace ConsoleApp1
{
 class DucksQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я умею крякать!");
        }
    }
 }
