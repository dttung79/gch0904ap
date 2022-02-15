using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;
        public int Denominator 
        {
            get { return denominator; }
            set 
            {
                if (value == 0)
                    throw new Exception("Denominator is zero!");
                else 
                    denominator = value;
            }
        }

        public Fraction()
        {
            numerator = denominator = 1;
        }
        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d; // -> set -> throw (if d == 0)
        }

        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        public Fraction Add(Fraction f)
        {
            int a = Numerator;
            int b = Denominator;
            int c = f.Numerator;
            int d = f.Denominator;

            int n = a*d + b*c;
            int d = b*d;

            return new Fraction(n, d);
        }
        // TODO: Subtract, Multiply, Divide
    }
}