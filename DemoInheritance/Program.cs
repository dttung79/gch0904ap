using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.ShowInfo();

            Student s = new Student("Minh", 20, "FGW");
            s.ShowInfo();
            //System.Console.WriteLine("School: " + s.School);
        }
    }
}
