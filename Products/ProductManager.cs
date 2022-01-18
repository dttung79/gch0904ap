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

        }

        private int GetChoice()
        {
            return 0;
        }

        private void DoTask(int choice)
        {

        }

        private void ShowProducts()
        {

        }

        private void AddProduct()
        {
            
        }
    }
}