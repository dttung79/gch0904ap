using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Student : Person
    {
        public string School {get; set;}
        public Student() : base("Default student", 18)
        {
            //Name = "Default student";
            //Age = 18;
            School = "FGW";
            System.Console.WriteLine("Student Inititate name, age: " + Name + ", " + Age);
        }

        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
            System.Console.WriteLine("Student Inititate name, age: " + Name + ", " + Age);
        }

        public void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("School: " + School);
        }
    }
}