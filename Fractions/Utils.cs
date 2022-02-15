using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fractions
{
    public class Utils
    {
        public static int GetInt(string message)
        {
            int n = 0;
            bool invalidInput = true;
            while (invalidInput)
            {
                try
                {
                    System.Console.Write(message);
                    n = Convert.ToInt32(Console.ReadLine());
                    invalidInput = false;
                } catch (FormatException ex) 
                {
                    System.Console.WriteLine("Error: not number. Please try again.!");
                }
            }
            return n;
        }

        public static Fraction GetFraction(string message)
        {
            System.Console.WriteLine(message);
            Fraction f = new Fraction();
            bool invalidFraction = true;
            while (invalidFraction)
            {
                try 
                {
                    int n = GetInt("Enter numerator: ");
                    int d = GetInt("Enter denominator: ");
                    f = new Fraction(n, d);
                    invalidFraction = false;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Error: Denominator is zero!");
                    System.Console.WriteLine("Please try again!");
                }
            }
            return f;
        }
    }
}