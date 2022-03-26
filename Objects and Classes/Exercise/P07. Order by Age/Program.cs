using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Order_by_Age
{
    class Person
    {
        public Person(string name, string personID, int age)
        {
            this.Name = name;
            this.ID = personID;
            this.Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] personArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personArgs[0];
                string personID = personArgs[1];
                int age = int.Parse(personArgs[2]);

                IsPersonAlreadyExist(persons, personID, name, age);

                Person newPerson = new Person(name, personID, age);
                persons.Add(newPerson);

                persons = persons.OrderBy(p => p.Age).ToList();
            }

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
        static void IsPersonAlreadyExist(List<Person> list, string personID, string name, int age)
        {
            foreach (Person person in list)
            {
                if (person.ID == personID)
                {
                    person.Name = name;
                    person.Age = age;
                }
            }
        }
    }
}
