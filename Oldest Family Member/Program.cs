using System;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public List<Person> AddMember(Person p);

        {
        List<Person> people = new List<Person>();
        people.Add(p);
            return people;
        }
}
}
