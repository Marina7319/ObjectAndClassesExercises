using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.OrderbyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(" ");
            List<Person> personsList = new List<Person>();
            while (commands[0] != "End")
            {
                var person = new Person(name: commands[0], id: int.Parse(commands[1]), age: int.Parse(commands[2]));
                foreach (Person persons in personsList)
                {
                    if (persons.Id == int.Parse(commands[1]))
                    {
                        personsList.Remove(person);
                    }
                }
                personsList.Add(person);
                commands = Console.ReadLine().Split(" ");
            }
            personsList = personsList.OrderBy(currAge => currAge.Age).ToList();
            foreach (Person personList in personsList)
            {
                Console.WriteLine(personList);
            }
        }
        class Person
        {
            public Person(string name, int id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }
            public string Name
            {
                get;
                set;
            }
            public int Id
            {
                get;
                set;
            }
            public int Age
            {
                get;
                set;
            }
            public override string ToString() => $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
