using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Oldest_Family_Member
{
    class Family
    {
        public Family()
        {
            this.FamilyList = new List<Person>();
        }
        public List<Person> FamilyList { get; set; }

        public void AddMember(Person person)
        {
            this.FamilyList.Add(person);
        }

        public Person GetOldestMember(List<Person> members)
        {
            Person oldestPerson = members.OrderByDescending(m => m.Age).FirstOrDefault();
            return oldestPerson;
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            Family family = new Family();
            
            int countOfMembers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfMembers; i++)
            {
                string[] memberArgs = Console.ReadLine()
                    .Split(' ');

                string name = memberArgs[0];
                int age = int.Parse(memberArgs[1]);

                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }
            
            Person oldestPerson = family.GetOldestMember(family.FamilyList);
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
