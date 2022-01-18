using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
        // Attributes
        private string name;
        private int price;
        private string category;
        // Properties
        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "") name = "Unknow Product";
                else name = value;
            }
        }

        public int Price
        {
            get { return price; }
            set { price = value; } // TODO: validate price >= 0
        }

        public string Category 
        {
            get { return category; }
            set { category = value; } // TODO: validate category != ""
        }


        // Constructors
        public Product()
        {
            Name = "Unknown product";
            Price = 0;
            Category = "Unknown category";
        }

        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Other methods
        public void ShowInfor() 
        {
            System.Console.WriteLine("Product name: " + Name);
            System.Console.WriteLine("Price: $" + Price);
            System.Console.WriteLine("Category: " + Category);
        }
    }
}