using System;

namespace Books
{
    public class Book
    {
        // name (not empty), price (> 0), pages (> 0)
        // attributes, properties (validate), 2 constructor, ShowBook
        private string name; // non-static datra | object data
        private double price;
        
        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // property Pages without attribute pages
        public int Pages { get; set; }

        private static int count = 0; // static data | class data

        public int id;
        public int ID 
        {
            get { return id; }
        }

        public Book()
        {
            name = "No name"; // Name = "No name"
            price = 1;        // Price = 1;
            Pages = 1;
            id = ++count;
        }

        public Book(string name, double price, int pages)
        {
            // this.name = name;
            Name = name;
            Price = price;
            Pages = pages;
            id = ++count;
        }

        public static int Count 
        {
            get { return count; }
        }

        public void ShowBook()
        {
            System.Console.WriteLine("(" + Name + ", $" + Price + ", " + Pages + " pages)" );
        }
    }
}