using System;
using System.Collections.Generic;

namespace strategy
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class PersonSortByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            else if (x.Age < y.Age)
            {
                return -1;
            }
            return 0;
            // OR: 
            //return x.Age - y.Age;
        }
    }

    class Program
    {
        static void Main()
        {
            var persons = new List<Person>
            {
                new Person {Name = "dave", Age = 23},
                new Person {Name = "mike", Age = 18},
                new Person {Name = "susie", Age = 22}
            };

            persons.Sort(new PersonSortByAge());

            Console.ReadLine();
        }
    }
}
