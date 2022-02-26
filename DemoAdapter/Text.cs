using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAdapter
{
    public class Text
    {
        public string Content { get; set; }
        public Text()
        {
            Content = "Hello";
        }

        public Text(string content)
        {
            Content = content;
        }
        
        public void Print()
        {
            for (int i = 0; i < Content.Length + 2; i ++) Console.Write("*");
            Console.WriteLine();

            Console.WriteLine("*" + Content + "*");

            for (int i = 0; i < Content.Length + 2; i ++) Console.Write("*");
            Console.WriteLine();
        }
    }
}