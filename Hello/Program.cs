using System;
using System.Collections.Generic;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            // System.Console.WriteLine(s.GetName());
            // System.Console.WriteLine(s.Grade);
            // System.Console.WriteLine(s.age);
            s.DisplayStudentInfo();

            Student minh = new Student("Le Minh", 20, 6.0);
            minh.DisplayStudentInfo();
        }
    }
}
