using System;
using System.Collections.Generic;

namespace Books
{
    class Program
    {
        private static List<Book> books = new List<Book>();
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
                if (choice == 0) break;
            }
        }

        static void PrintMenu()
        {
            System.Console.WriteLine("Book management program");
            System.Console.WriteLine("1. Add book.");
            System.Console.WriteLine("2. Find book.");
            System.Console.WriteLine("3. Delete book.");
            System.Console.WriteLine("4. Edit book.");
            System.Console.WriteLine("5. Show all books");
            System.Console.Write("Your choice: ");
        }
        static void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddBook(); break;
                case 2: FindBook(); break;
                case 3: DeleteBook(); break;
                case 4: EditBook(); break;
                case 5: ShowAllBooks(); break;
                case 0: System.Console.WriteLine("See you!"); break;
                default: System.Console.WriteLine("Invalid choice!"); break;
            }
        }

        static void AddBook()
        {
            System.Console.WriteLine("Add New Book");
            // ask user to enter book's info (name, price, pages)
            System.Console.Write("Enter book name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter book price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter number of pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());
            // create new book object
            Book b = new Book(name, price, pages);
            // add book object to list books
            books.Add(b);
            System.Console.WriteLine("Add book successfule. Number of books: " + Book.Count);
        }
        static void FindBook()
        {
            System.Console.WriteLine("Find Book by name");
            // ask user to enter book name
            System.Console.Write("Enter book name to find: ");
            string name = Console.ReadLine();
            bool found = false;
            // use for loop to find a book which has that name
            for (int i = 0; i < books.Count; i++)
            {
                // print found book's info
                if (books[i].Name == name) 
                {
                    books[i].ShowBook();
                    found = true;
                }
            }
            if (!found) System.Console.WriteLine("No books found!");
        }
        static void DeleteBook()
        {
            System.Console.WriteLine("Delete Book by ID");
            // ask user to enter id
            System.Console.Write("Enter book id to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            // find book by id
            bool found = false;
            foreach (Book b in books)
            {
                if (b.ID == id)
                {
                    // delete book
                    books.Remove(b);
                    found = true;
                    break;
                }
            }
            if (!found) System.Console.WriteLine("No books found!");
        }
        static void EditBook()
        {
            System.Console.WriteLine("Edit Book by ID");
            // Home work
            // ask user to enter id
            System.Console.Write("Enter book id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            // find book by id
            bool found = false;
            foreach (Book b in books)
            {
                if (b.ID == id)
                {
                    // show old book's info
                    b.ShowBook();
                    // ask user to enter book's info (name, price, pages)
                    System.Console.Write("Enter book name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Enter book price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Enter number of pages: ");
                    int pages = Convert.ToInt32(Console.ReadLine());
                    // change book's info to what user entered.
                    b.Name = name;
                    b.Price = price;
                    b.Pages = pages;

                    found = true;
                    break;
                }
            }
            if (!found) System.Console.WriteLine("No books found!"); 
            
        }

        static void ShowAllBooks()
        {
            // Homework: use for loop to print all book's info
            foreach (Book b in books)
            {
                b.ShowBook();
                System.Console.WriteLine("-------------------------------");
            }
        }
    }
}
