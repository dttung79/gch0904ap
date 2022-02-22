using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public Person()
        {
            Name = "No name";
            Age = 1;
            System.Console.WriteLine("Person Inititate name, age: " + Name + ", " + Age);
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Person Inititate name, age: " + Name + ", " + Age);
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Name: " + Name);
            System.Console.WriteLine("Age: " + Age);
        }
    }
}