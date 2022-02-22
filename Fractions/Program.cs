using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: using GetFraction, ask user to enter 2 fractions f1, f2
            // Print f1, f2
            Fraction f1 = Utils.GetFraction("Enter fraction f1: ");
            Fraction f2 = Utils.GetFraction("Enter fraction f2: ");

            System.Console.WriteLine("f1 = " + f1);
            System.Console.WriteLine("f2 = " + f2);

            // TODO: Thuc hien cac phep tinh +-*/ in ra ket qua
            Fraction f3 = f1.Add(f2);
            f3.Simplify();
            System.Console.WriteLine(f1 + " + " + f2 + " = " + f3);
        }
    }
}
