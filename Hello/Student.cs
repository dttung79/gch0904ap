using System;

namespace Hello
{
    public class Student : Object
    {
        // Attributes
        private string name;
        public int age;
        private double grade;

        // Methods
        // to provide read acces for attribute name
        public string GetName()
        {
            return name;
        }
        // to provide wirte access for attribute name
        public void SetName(string name)
        {
            if (name == "") this.name = "Mai";
            else this.name = name;
        }

        public double Grade // property
        {
            get { return grade; }
            set 
            {
                if (value < 0) grade = 0;
                else grade = value;
            }
        }

        public Student()
        {
            name = "Nguyen Van An";
            age = 18;
            grade = 0.0;
        }
        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        // Methods
        public void DisplayStudentInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Age: " + age);
            System.Console.WriteLine("Grade: " + grade);
        }
    }
}