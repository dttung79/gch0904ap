using System;
using System.Collections.Generic;

namespace Products
{
    public class ProductManager
    {
        private List<Product> products;
        public ProductManager()
        {
            products = new List<Product>();
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        private void PrintMenu()
        {
            System.Console.WriteLine("Product Management Program");
            System.Console.WriteLine("1. Add Products");
            System.Console.WriteLine("2. Edit Product"); // TODO
            System.Console.WriteLine("3. Delete Product"); // TODO
            System.Console.WriteLine("4. Show Products");
        }

        private int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddProduct(); break;
                case 2: break; // TODO
                case 3: break; // TODO
                case 4: ShowProducts(); break;
                case 0: break;
                default: ShowError(); break;
            }
        }
        private void ShowError()
        {
            System.Console.WriteLine("Invalid Choice!");
        }

        private void ShowProducts()
        {
            foreach(Product p in products) 
            {
                p.ShowInfor();
            }
        }

        private void AddProduct()
        {
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter product price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            
            string category = ChooseCategory();

            Product p = new Product(name, price, category);
            products.Add(p);
            System.Console.WriteLine("Product added successful!");
            System.Console.WriteLine("--------------------------------------------");
        }


        private string ChooseCategory()
        {
            bool correctCategory = false;
            // string category = "";
            // while (!correctCategory)
            // {
            //     System.Console.WriteLine("Choose a category");
            //     System.Console.WriteLine("- Clothes");
            //     System.Console.WriteLine("- Furniture");
            //     System.Console.WriteLine("- Kitchen");
            //     System.Console.Write("Your choice: ");
            //     category = Console.ReadLine();
            //     if (category == "Clothes" || category == "Furniture" || category == "Kitchen") correctCategory = true;
            //     else System.Console.WriteLine("Invalid category. Choose again!");
            // }
            // return category;

            string[] categories = {"", "Clothes", "Furniture", "Kitchen"};
            int choice = 0;
            while (!correctCategory)
            {
                System.Console.WriteLine("Choose a category");
                
                for(int i = 1; i < categories.Length; i++)
                    System.Console.WriteLine(i + ". " + categories[i]); // 1. Clothes

                System.Console.Write("Your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 0 && choice < categories.Length) correctCategory = true;
                else System.Console.WriteLine("Invalid category. Choose again!");
            }
            return categories[choice];
        }
    }
}