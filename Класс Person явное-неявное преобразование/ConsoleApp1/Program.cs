using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Вася", "Пупкин");
            string str = (string)person;
            Console.WriteLine(str);

            person = "Петр Долгопрудный";
            Console.WriteLine($"{person.FirstName} {person.LastName}");

            if ((string)person == "Петр Долгопрудный")
                Console.WriteLine("== объекты равны");

            if (Equals((string)person, "Петр Долгопрудный"))
                Console.WriteLine("Equals() вернул true");

            if (!Equals(person, "Петр Долгопрудный"))
                Console.WriteLine("Equals() вернул false");

            Console.ReadKey();
        }
    }
}
