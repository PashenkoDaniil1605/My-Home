using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        // Явное приведение объекта Person к типу string
        public static explicit operator string(Person ob)
        {
            return string.Format($"{ob.FirstName} {ob.LastName}");
        }
        // Неявное приведение типа string к объекту Person
        public static implicit operator Person(string ob)
        {
            string[] arr = ob.Split(new char[] { ' ' });
            return new Person(arr[0], arr[1]);
        }
    }
}
