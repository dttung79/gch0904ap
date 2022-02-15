using System;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            // try 
            // {
            //     System.Console.Write("Enter a: ");
            //     int a = Convert.ToInt32(Console.ReadLine());
            //     System.Console.Write("Enter b: ");
            //     int b = Convert.ToInt32(Console.ReadLine());

            //     int c = a / b;
            //     System.Console.WriteLine("c = " + c);
            // } catch (DivideByZeroException e1) 
            // {
            //    System.Console.WriteLine("Error: " + e1.Message);
            // } catch (FormatException e2)
            // {
            //     System.Console.WriteLine("Are you stupid?");
            // }

            // System.Console.WriteLine("Program ends successfully");

            // Viet chuong trinh nhap vao 10 so nguyen
            // Nhap 1 so n va tinh trung binh a[0] ... a[n]
            int[] a = new int[10];
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                a[i] = GetInt("Enter a[" + i + "]: ");
            }
            int n = GetInt("Enter n: ");

            try
            {
                for (int i = 0; i <= n; i++)
                {
                    s += a[i];
                }

                double m = (double) s / (n + 1);
                System.Console.WriteLine("Average = " + m);
            } catch (IndexOutOfRangeException ie)
            {
                System.Console.WriteLine("Error: n should be in range [0, 9]");
            } catch (DivideByZeroException de)
            {
                System.Console.WriteLine("Error: Divided by zero!");
            }
        }

        static int GetInt(string message) 
        {
            int n = 0;
            while (true)
            {
                try
                {
                    System.Console.Write(message);
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                } catch (FormatException ex) 
                {
                    System.Console.WriteLine("Error: not number. Please try again.!");
                }
            }
            return n;
        }
    }

    
}
